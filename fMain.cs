using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataCentreSimulator
{
    public partial class fMain : Form
    {
        private DataCentre _dataCentre = new DataCentre();
        public fMain()
        {
            InitializeComponent();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        // Test Problem Tab
        private void btImport_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFile.FileName);
                _dataCentre.Load(streamReader);
                cbNumberOfPMs.Text = _dataCentre._numberofpms.ToString();
                cbNumberOfVMs.Text = _dataCentre._numberofvms.ToString();
                cbNumberOfVariations.Text = _dataCentre._numberofvariations.ToString();
                cbNumberOfChanges.Text = _dataCentre._numberofchanges.ToString();
                cbDuration.Text = _dataCentre._duration.ToString(); ;
                rtbInformation.Text = string.Format("Number of PMs: {0}\r\nNumber of VMs: {1}\r\nNumber of Variations: {2}\r\nNumber of Changes: {3}\r\nDuration: {4}\r\n", cbNumberOfPMs.Text, cbNumberOfVMs.Text, cbNumberOfVariations.Text, cbNumberOfChanges.Text, cbDuration.Text);
                streamReader.Close();
                Problem2StaticChart(_dataCentre, ref chartStatic);
                chartStatic.ChartAreas[0].AxisX.Maximum = _dataCentre._duration + 1;
                btReset_Click(sender, e);
                tabControl.SelectTab(1);
            }
            else { }
        }
        private void btExport_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFile.FileName);
                _dataCentre.Save(streamWriter);
                streamWriter.Close();
            }
            else { }
        }
        private void btCreate_Click(object sender, EventArgs e)
        {
            _dataCentre.Problematize(int.Parse(cbNumberOfPMs.Text), int.Parse(cbNumberOfVMs.Text), int.Parse(cbNumberOfVariations.Text), int.Parse(cbNumberOfChanges.Text), int.Parse(cbDuration.Text));
            rtbInformation.Text = string.Format("Number of PMs: {0}\r\nNumber of VMs: {1}\r\nNumber of Variations: {2}\r\nNumber of Changes: {3}\r\nDuration: {4}\r\n", cbNumberOfPMs.Text, cbNumberOfVMs.Text, cbNumberOfVariations.Text, cbNumberOfChanges.Text, cbDuration.Text);
            Problem2StaticChart(_dataCentre, ref chartStatic);
            chartStatic.ChartAreas[0].AxisX.Maximum = _dataCentre._duration + 1;
            btReset_Click(sender, e);
            tabControl.SelectTab(1);
        }
        //////////////////////////////////////////////////////////////////////////
        // Algorithm Tab
        private void cbAlgorithms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAlgorithms.SelectedIndex == 2)            //GA
            {
                cbCrossoverProbability.Visible = true;
                cbMutationProbability.Visible = true;
                cbTermination.Visible = true;
                cbPopulationSize.Visible = true;
                cbDCGASize.Visible = false;
                lbCrossoverProbability.Visible = true;
                lbMutationProbability.Visible = true;
                lbTermination.Visible = true;
                lbPopulationSize.Visible = true;
                lbDCGASize.Visible = false;
            }
            else if (cbAlgorithms.SelectedIndex == 3)       // DCGA
            {
                cbCrossoverProbability.Visible = true;
                cbMutationProbability.Visible = true;
                cbTermination.Visible = true;
                cbPopulationSize.Visible = true;
                cbDCGASize.Visible = true;
                lbCrossoverProbability.Visible = true;
                lbMutationProbability.Visible = true;
                lbTermination.Visible = true;
                lbPopulationSize.Visible = true;
                lbDCGASize.Visible = true;
            }
            else // FFD, FF, FFA
            {
                cbCrossoverProbability.Visible = false;
                cbMutationProbability.Visible = false;
                cbTermination.Visible = false;
                cbPopulationSize.Visible = false;
                cbDCGASize.Visible = false;
                lbCrossoverProbability.Visible = false;
                lbMutationProbability.Visible = false;
                lbTermination.Visible = false;
                lbPopulationSize.Visible = false;
                lbDCGASize.Visible = false;
            }
        }
        private void thread_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            e.Result = _dataCentre.Solve((Algorithm)e.Argument);
        }
        private void thread_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result == true)
            {
                lbStatus.Text = "Found the solution.";
                btReset_Click(sender, e);
                rtbInformation.Text += String.Format("The {0} energy consumption: {1}\r\n", cbAlgorithms.Text, (int)_dataCentre.E());
            }
            else {
                lbStatus.Text = "No solutions found.";
            }
            timerSolve.Stop();
            btSolve.Text = "Solve";
        }
        private void btSolve_Click(object sender, EventArgs e)
        {
            lbStatus.Text = "";
            if (thread.IsBusy == true)
            {
                btSolve.Text = "Solve";
                timerSolve.Stop();
                thread.CancelAsync();
            }
            else
            {
                _timeSolve = 0;
                timerSolve.Start();
                thread.RunWorkerAsync(new Algorithm(cbAlgorithms.SelectedIndex, int.Parse(cbTermination.Text), int.Parse(cbPopulationSize.Text), int.Parse(cbDCGASize.Text), double.Parse(cbCrossoverProbability.Text), double.Parse(cbMutationProbability.Text)));
            }
        }
        private int _timeSolve = 0;
        private void timerSolve_Tick(object sender, EventArgs e)
        {
            btSolve.Text = "Running... " + (++_timeSolve).ToString() + "s";
        }
        //////////////////////////////////////////////////////////////////////////
        // Visualization Tab
        // Problem to Static Chart for number of online and offline virtual machines
        public void Problem2StaticChart(DataCentre iDataCentre, ref Chart chart)
        {
            List<Variation> iObjects = iDataCentre._variations;
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            for (int i = 0; i < iObjects.Count; ++i)
            {
                chart.Series[0].Points.Add(new DataPoint(iObjects[i]._time,
                    iObjects[i]._vmsoff.Count));
                chart.Series[1].Points.Add(new DataPoint(iObjects[i]._time, -
                    iObjects[i]._vmson.Count));
            }
            chart.ChartAreas[0].AxisX.Maximum = iDataCentre._duration;
        }
        private int iTick = 0;
        private double previousY = 0;
        private double currentY = 0;
        // Solutions to Dynamic Chart for energy information
        private void timer_Tick(object sender, EventArgs e)
        {
            if (iTick == _dataCentre._variations[_dataCentre._variationmax]._time)
            {
                currentY = _dataCentre._variations[_dataCentre._variationmax].E();
                if (iTick != 0)
                {
                    chartDynamic.Series[0].Points.Add(new DataPoint(iTick, new[] { previousY, 0 }));
                }
                else { }
                chartDynamic.Series[0].Points.Add(new DataPoint(iTick, new[] { currentY, 0 }));
                chartDynamic.Series[0].Points[chartDynamic.Series[0].Points.Count - 1].Label = ((int)currentY).ToString();
                previousY = currentY;
                ++_dataCentre._variationmax;
                if (_dataCentre._variationmax == _dataCentre._variations.Count)
                {
                    --_dataCentre._variationmax;
                }
            }
            else
            {
                chartDynamic.Series[0].Points.Add(new DataPoint(iTick, new[] { (double)(int)previousY, 0 }));
            }
            if (iTick == _dataCentre._duration)
            {
                timer.Stop();
            }
            ++iTick;
        }
        // Play and Reset the Dynamic Chart
        private void btPlay_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == false)
            {
                timer.Start();
                btPlay.Text = "Pause";
            }
            else
            {
                timer.Stop();
                btPlay.Text = "Play";
            }
        }
        private void btReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btPlay.Text = "Play";
            _dataCentre._variationmax = 0;
            chartDynamic.Series[0].Points.Clear();
            iTick = 0;
        }
        // Solution to List View for detailed cpu, ram information when clicking on Static Chart
        private int iSelectedVariation = 0;
        private void chartStatic_MouseClick(object sender, MouseEventArgs e)
        {
            int iTick = (int)chartStatic.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
            for (int i = _dataCentre._variations.Count - 1; i < _dataCentre._variations.Count; --i)
            {
                if (iTick >= _dataCentre._variations[i]._time)
                {
                    iSelectedVariation = i;
                    PhysicalMachines2ListView(_dataCentre._variations[i], ref lvPMs, ref lvOffline, ref lvOnline);
                    tabStatus.Text = "Status at time: " + iTick.ToString();
                    tabControl.SelectTab(3);
                    break;
                }
                else { }
            }
        }
        // Solution to List View for detailed cpu, ram information when clicking on Dynamic Chart
        private void chartDynamic_MouseClick(object sender, MouseEventArgs e)
        {
            int iTick = (int)chartDynamic.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
            for (int i = _dataCentre._variations.Count - 1; i < _dataCentre._variations.Count; --i)
            {
                if (iTick >= _dataCentre._variations[i]._time)
                {
                    iSelectedVariation = i;
                    PhysicalMachines2ListView(_dataCentre._variations[i], ref lvPMs, ref lvOffline, ref lvOnline);
                    tabStatus.Text = "Status at time: " + iTick.ToString();
                    tabControl.SelectTab(3);
                    break;
                }
                else { }
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        // Status Tab
        // Physical machines to ListView
        public void PhysicalMachines2ListView(Variation iDataCentreState, ref ListView oListViewPMs, ref ListView oListViewOfflines, ref ListView oListViewOnlines)
        {
            oListViewPMs.Items.Clear();
            for (int i = 0; i < iDataCentreState._pms.Count; ++i)
            {
                PhysicalMachine pm = iDataCentreState._pms[i];
                double energyEfficency = (pm._emax - pm._emin) / pm._cpu;
                ListViewItem listViewItem = new ListViewItem(new string[] { pm._id.ToString(), pm._cpu.ToString(), pm._ram.ToString(), pm._emin.ToString(), pm._emax.ToString(), pm._k.ToString(), pm._vms.Count.ToString(), pm._wcpu.ToString(), pm._wram.ToString(),pm.E().ToString(), energyEfficency.ToString()});
                oListViewPMs.Items.Add(listViewItem);
            }
            oListViewOfflines.Items.Clear();
            for (int i = 0; i < iDataCentreState._vmson.Count; ++i)
            {
                VirtualMachine vm = iDataCentreState._vmson[i];
                ListViewItem listViewItem = new ListViewItem(new string[] { vm._id.ToString(), vm._cpu.ToString(), vm._ram.ToString() });
                oListViewOfflines.Items.Add(listViewItem);
            }
            oListViewOnlines.Items.Clear();
            for (int i = 0; i < iDataCentreState._vmsoff.Count; ++i)
            {
                VirtualMachine vm = iDataCentreState._vmsoff[i];
                ListViewItem listViewItem = new ListViewItem(new string[] { vm._id.ToString(), vm._cpu.ToString(), vm._ram.ToString() });
                oListViewOnlines.Items.Add(listViewItem);
            }

        }
        // Virtual machines to ListView
        public void VirtualMachines2ListView(int iPM, Variation iDataCentreState, ref ListView oListViewVMs)
        {
            oListViewVMs.Items.Clear();
            PhysicalMachine pm = iDataCentreState._pms[iPM];
            for (int i = 0; i < pm._vms.Count; ++i)
            {
                VirtualMachine vm = pm._vms[i];
                ListViewItem listViewItem = new ListViewItem(new string[] { vm._id.ToString(), vm._cpu.ToString(), vm._ram.ToString() });
                oListViewVMs.Items.Add(listViewItem);
            }
        }
        private void lvPMs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPMs.SelectedItems.Count > 0)
            {
                VirtualMachines2ListView(lvPMs.SelectedItems[0].Index, _dataCentre._variations[iSelectedVariation], ref lvVMs);
            }
            else { }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        // Menu events
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void contentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Help.pdf");
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Licensed to" +
                            "Student: Tri Vu Chau. Email: vincentchauau@gmail.com." +
                "\nSupervisor: Maolin Tang. Queensland University of Technology." +
                "\nDate: 21/05/2017. Version: 2.0", "About");
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        // Form Events
        private void fMain_Resize(object sender, EventArgs e)
        {
            lvPMs.Width = Size.Width / 2 - 10;
            lvVMs.Left = Size.Width / 2 + 10;
            lvVMs.Width = Size.Width / 2 - 10;
        }
        private void fMain_Load(object sender, EventArgs e)
        {
            lvPMs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvOffline.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvOnline.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            if (File.Exists("default.txt"))
            {
                StreamReader streamReader = new StreamReader("default.txt");
                _dataCentre.Load(streamReader);
                streamReader.Close();
                Problem2StaticChart(_dataCentre, ref chartStatic);
                chartStatic.ChartAreas[0].AxisX.Maximum = _dataCentre._duration + 2;
                btReset_Click(sender, e);
            }
        }
        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_dataCentre._variations.Count > 0)
            {
                StreamWriter streamWriter = new StreamWriter("default.txt");
                _dataCentre.Save(streamWriter);
                streamWriter.Close();
            }
        }
    }
}
