using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
namespace DataCentreSimulator
{
    // Algorithm class: GA and DCGA algorithm parameters
    public class Algorithm
    {
        public int _id, _termination, _populationsize, _dcgasize;
        public double _pcrossover, _pmutation;
        public Algorithm(int id, int termination, int populationsize, int dcgasize, double pcrossover, double pmutation)
        {
            _id = id;
            _termination = termination;
            _populationsize = populationsize;
            _dcgasize = dcgasize;
            _pcrossover = pcrossover;
            _pmutation = pmutation;
        }
    }
    // VirtualMachine class
    [Serializable]
    public class VirtualMachine
    {
        public int _id, _cpu, _ram;
        public VirtualMachine()
        {
            _id = ++DataCentre._vidmax;
            _cpu = DataCentre._vcpus[DataCentre._random.Next(8)];
            _ram = DataCentre._vrams[DataCentre._random.Next(8)];
        }
        public VirtualMachine(int id, int cpu, int ram)
        {
            _id = id;
            _cpu = cpu;
            _ram = ram;
        }
    }
    // PhysicalMachine class
    [Serializable]
    public class PhysicalMachine : IComparable
    {
        public int _id, _cpu, _ram, _wcpu, _wram;
        public double _emin, _emax, _k;
        public List<VirtualMachine> _vms;
        public PhysicalMachine()
        {
            _id = ++DataCentre._pidmax;
            _cpu = DataCentre._pcpus[DataCentre._random.Next(8)];
            _ram = DataCentre._prams[DataCentre._random.Next(8)];
            _wcpu = 0;
            _wram = 0;
            _emax = DataCentre._random.Next(300, 500);
            _emin = (double)DataCentre._random.NextDouble() * 10;
            //_emin = (double)DataCentre._random.Next(30, 50) / 100 * _emax;
            _k = _wcpu/_cpu;
            _vms = new List<VirtualMachine>();
        }
        public PhysicalMachine(int id, int cpu, int ram, double emin, double emax, double k, List<VirtualMachine> vms)
        {
            _id = id;
            _cpu = cpu;
            _ram = ram;
            _emin = emin;
            _emax = emax;
            _k = k;
            _vms = vms;
        }
        // Sort physical machines decreasingly as default for FFD
        public int CompareTo(object o)
        {
            PhysicalMachine pm = o as PhysicalMachine;
            if ((_emax - _emin) / _cpu > (pm._emax - pm._emin) / pm._cpu)  // return if this physical machine has higher energy efficiency
            {
                return -1;
            }
            else if ((_emax - _emin) / _cpu < (pm._emax - pm._emin) / pm._cpu) // return -1 if this machine has lower energy efficiency
            {
                return 1;
            }
            else // return 0 if compared equally
            {
                return 0;
            }
        }
        // Current energy in a physical machine
        public double E()
        {
            if (_k == 0)
            {
                return 0;
            }
            else
            {
                return _emin + _k * (_emax - _emin);
            }
        }
    }
    // Variation class
    [Serializable]
    public class Variation
    {
        public int _time;
        public List<PhysicalMachine> _pms;      // Physical machines
        public List<VirtualMachine> _vms;       // Virtual machines
        public List<VirtualMachine> _vmson;     // Online virtual machines
        public List<VirtualMachine> _vmsoff;    // Offline virtual machines
        public Variation()
        {
            _pms = new List<PhysicalMachine>();
            _vms = new List<VirtualMachine>();
            _vmson = new List<VirtualMachine>();
            _vmsoff = new List<VirtualMachine>();
        }
        // Add all virtual machines to physical machines: add _vms to _pms
        public int FFAddVMs2PMs()
        {
            int cpuremaining = 0, ramremaining = 0;
            int numberofpms = 0;
            for (int i = 0; i < _vms.Count; ++i)
            {
                for (int j = 0; j < _pms.Count; ++j)
                {
                    cpuremaining = _pms[j]._cpu - _pms[j]._wcpu;
                    ramremaining = _pms[j]._ram - _pms[j]._wram;
                    if (_vms[i]._cpu <= cpuremaining && _vms[i]._ram <= ramremaining)
                    {
                        _pms[j]._vms.Insert(0, _vms[i]);
                        _pms[j]._wcpu += _vms[i]._cpu;
                        _pms[j]._wram += _vms[i]._ram;
                        _pms[j]._k = (double)_pms[j]._wcpu / (double)_pms[j]._cpu;
                        numberofpms = j + 1;
                        break;
                    }
                    else { }
                }
            }
            return numberofpms;
        }
        // Maximum energy of all physical machines in a variation
        public double Emax()
        {
            double max = 0;
            for (int i = 0; i < _pms.Count; ++i)
            {
                max += _pms[i]._emax;
            }
            return max;
        }
        // Minimum energy of all physical machines in a variation
        public double Emin()
        {
            double min = 0;
            for (int i = 0; i < _pms.Count; ++i)
            {
                min += _pms[i]._emin;
            }
            return min;
        }
        // Current energy of all physical machines in a variation
        public double E()
        {
            double Ex = 0;
            for (int i = 0; i < _pms.Count; ++i)
            {
                Ex += _pms[i].E();
            }
            return Ex;
        }
        // GA, DCGA parameters 
        // solution x = solutions[x][index] = value with index = 0..indexRange, value = 0..valueRange
        // crossover and mutation probabilities
        public int _populationsize, _indexRange, _valueRange, _termination, _dcgasize;
        public double _pcrossover, _pmutation;
        // population = solutions = solutions[_populationSize] = _population[_populationSize][]
        public int[][] _population; 
        // best fitness, best average fitness, best solution            
        public int[] _bestSolution;
        public double _bestFitness;
        public double _bestAverageFitness;
        // fitness is not updated yet
        public int _noupdate;
        // Initiate randomly GA population
        public void InitiateGA(int populationsize, int indexrange, int valuerange, int termination, double pcrossover, double pmutation)
        {
            DataCentre._random = new Random((int)DateTime.Now.Ticks);
            _populationsize = populationsize;
            _indexRange = indexrange;
            _valueRange = valuerange;
            _termination = termination;
            _pcrossover = pcrossover;
            _pmutation = pmutation;
            _population = new int[_populationsize][];
            _bestFitness = 0;
            _bestAverageFitness = 0;
            _noupdate = 0;
            for (int i = 0; i < _populationsize; ++i)
            {
                _population[i] = new int[_indexRange];
                for (int j = 0; j < _indexRange; ++j)
                {
                    _population[i][j] = DataCentre._random.Next(_valueRange);
                }
            }
        }
        // Initiate randomly DCGA population
        public void InitiateDCGA(int populationsize, int indexrange, int termination, int dcgasize, double pcrossover, double pmutation)
        {
            _populationsize = populationsize;
            _indexRange = indexrange;
            _valueRange = FFAddVMs2PMs();
            _valueRange += dcgasize;
            if (_valueRange > _pms.Count)
                _valueRange = _pms.Count;
            else { }
            _termination = termination;
            _pcrossover = pcrossover;
            _pmutation = pmutation;
            _population = new int[_populationsize][];
            _bestFitness = 0;
            _bestAverageFitness = 0;
            _noupdate = 0;
            for (int i = 0; i < _populationsize; ++i)
            {
                _population[i] = new int[_indexRange];
                for (int j = 0; j < _indexRange; ++j)
                {
                    _population[i][j] = DataCentre._random.Next(_valueRange);
                }
            }
        }
        // Fitness function
        public double Fitness(int[] solution)
        {
            Solution2Variation(solution);
            //if (ViolationCounter() == 0)
            //{
            //    fitness = 0.5 + (Emax() - E()) / (2.0 * Emax());

            //}
            //else
            //{
            //    int violationCounter = ViolationCounter();
            //    fitness = ((Emax() - E()) / Emax() / 2); // fitness < 0.5
            //}
            double violation = 1 / (double)(CountViolation() + 1);
            double erate = Emax() / E();
            double prate = (double)_pms.Count/ (double)solution.Distinct().ToList().Count;
            return erate * prate * violation;
        }
        // Select a solution j for solution i to crossover by roulette wheel rule
        private int Selection(int i)
        {
            int j = i + 1;
            double[] values = new double[_populationsize];
            for (int k = 0; k < _populationsize; k++)
            {
                values[k] = 0;
            }
            for (int k = 1; k < _populationsize; k++)
            {
                int index = (i + k) % _populationsize;
                values[k] = values[k - 1] + Fitness(_population[index]);
            }

            Random r = new Random();
            double num = r.NextDouble() * values[_populationsize - 1];
            for (int k = 1; k < _populationsize; k++)
            {
                if (num <= values[k])
                {
                    j = k;
                    break;
                }
            }
            return (i + j) % _populationsize;
        }
        // Crossover two solutions to give another solution
        public int[] CrossOver(int[] parent1, int[] parent2)
        {
            int[] child = new int[_indexRange];
            double fitness1 = Fitness(parent1);
            double fitness2 = Fitness(parent2);
            double possibility = fitness1 / (fitness1 + fitness2);
            double value = 0;
            for (int i = 0; i < _indexRange; i++)
            {
                value = DataCentre._random.NextDouble();
                if (value < possibility)
                {
                    child[i] = parent1[i];
                }
                else
                {
                    child[i] = parent2[i];
                }
            }
            return child;
        }
        // Mutate a solution
        public int[] Mutation(int[] individual)
        {
            int index = DataCentre._random.Next(_indexRange);
            int value = DataCentre._random.Next(_valueRange);
            individual[index] = value;
            return individual;
        }
        // Update fitness
        public bool UpdateFitness()
        {
            double fitness = 0.0, averageFitness = 0.0;
            int index = -1;
            for (int i = 0; i < _populationsize; ++i)
            {
                fitness = Fitness(_population[i]);
                averageFitness += fitness;
                if (_bestFitness < fitness)
                {
                    _bestFitness = fitness;
                    index = i;
                }
                else { }
            }
            if (_bestAverageFitness < averageFitness && index >= 0)
            {
                _bestAverageFitness = averageFitness;
                _bestSolution = DataCentre.DeepCopy(_population[index]);
                return true;
            }
            else { }
            return false;
        }
        // Convert a solution to a variation
        void Solution2Variation(int[] solution)
        {
            foreach (PhysicalMachine pm in _pms)
            {
                pm._vms.Clear();
                pm._wcpu = 0;
                pm._wram = 0;
                pm._k = 0;
            }
            for (int i = 0; i < solution.Length; ++i)
            {
                _pms[solution[i]]._vms.Add(_vms[i]);
                _pms[solution[i]]._wcpu += _vms[i]._cpu;
                _pms[solution[i]]._wram += _vms[i]._ram;
                _pms[solution[i]]._k = (double)_pms[solution[i]]._wcpu / (double)_pms[solution[i]]._cpu;
            }
        }
        // Count Violation: count how many physical machines violated by constraints cpu and ram capcity
        public int CountViolation()
        {
            int violationCounter = 0;
            for (int i = 0; i < _pms.Count; ++i)
            {
                if (_pms[i]._wcpu > _pms[i]._cpu  || _pms[i]._wram > _pms[i]._ram)
                {
                    ++violationCounter;
                }
                else { }
            }
            return violationCounter;
        }
        // Evolve the GA population
        public void Evolve()
        {
            while (_noupdate < _termination)
            {
                int[][] newpopulation = DataCentre.DeepCopy(_population);
                for (int i = 0; i < _populationsize; ++i)
                {
                    DataCentre._random = new Random((int)DateTime.Now.Ticks);
                    if (DataCentre._random.NextDouble() <= _pcrossover)
                    {
                        int j = Selection(i);
                        int[] child = CrossOver(_population[i], _population[j]);
                        if (Fitness(child) > Fitness(newpopulation[i]))
                        {
                            newpopulation[i] = child;
                        }
                        else { }
                    }
                    else { }
                    DataCentre._random = new Random((int)DateTime.Now.Ticks);
                    if (DataCentre._random.NextDouble() <= _pmutation)
                    {
                        newpopulation[i] = Mutation(newpopulation[i]);
                    }
                    else { }

                }
                _population = DataCentre.DeepCopy(newpopulation);
                if (UpdateFitness())
                {
                    _noupdate = 0;
                }
                else
                {
                    ++_noupdate;
                }
            }
        }
        // Add virtual machines to physical machines in a variation by GA
        public int GAAddVMs2PMs(int populationSize, int indexRange, int valueRange, int termination, double pCrossover, double pMutation)
        {
            InitiateGA(populationSize, indexRange, valueRange, termination, pCrossover, pMutation);
            Evolve();
            Solution2Variation(_bestSolution);
            return CountViolation();
        }
        // Add virtual machines to physical machines in a variation by DCGA
        public int DCGAVMs2PMs(int populationSize, int indexRange, int termination, int dcgasize, double pCrossover, double pMutation)
        {
            InitiateDCGA(populationSize, indexRange, termination, dcgasize, pCrossover, pMutation);
            Evolve();
            Solution2Variation(_bestSolution);
            int violationCounter = CountViolation();
            return CountViolation();
        }
    }
    // Data Centre class
    [Serializable]
    public class DataCentre
    {
        public int _numberofpms;
        public int _numberofvms;
        public int _numberofvariations;
        public int _numberofchanges;
        public int _duration;

        public List<PhysicalMachine> _pms;
        public List<VirtualMachine> _vms;
        public List<Variation> _variations;

        public static int _pidmax;
        public static int _vidmax;
        public int _variationmax;
        public static List<int> _vcpus;
        public static List<int> _vrams;
        public static List<int> _pcpus;
        public static List<int> _prams;
        public static Random _random;
        public DataCentre()
        {
            _numberofpms = _numberofvms = _numberofvariations = _numberofchanges = _duration = 0;
            _pidmax = _vidmax = 0;
            _vcpus = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            _vrams = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            _pcpus = new List<int> { 100, 200, 300, 400, 500, 600, 700, 800};
            _prams = new List<int> { 100, 200, 300, 400, 500, 600, 700, 800};
            _pms = new List<PhysicalMachine>();
            _vms = new List<VirtualMachine>();
            _variations = new List<Variation>();
            _random = new Random((int)DateTime.Now.Ticks);
        }
        public static T DeepCopy<T>(T a)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, a);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }
        }
        public List<int> _randomizeValues(int iNumberOfValues, int iMax)
        {
            List<int> result = new List<int>();
            if (iNumberOfValues < iMax + 1)
            {
                while (result.Distinct().ToList().Count < iNumberOfValues)
                {
                    result.Add(_random.Next(1, iMax + 1));
                }
                result = result.Distinct().ToList();
                result.Sort();
            }
            else { }
            return result;
        }
        public double E()
        {
            double e = 0;
            int i = 0;
            for (i = 0; i < _variations.Count - 1; ++i)
            {
                e += _variations[i].E() * (_variations[i + 1]._time - _variations[i]._time);//Maolin 
            }
            e += _variations[i].E() * (_duration - _variations[i]._time);
            return e;
        }

        public bool Solve(Algorithm algorithm)
        {
            List<PhysicalMachine> pms = DeepCopy(_pms);
            switch (algorithm._id)
            {
                case 0: // FFD
                    pms.Sort();
                    for (int i = 0; i < _variations.Count; ++i)
                    {
                        _variations[i]._pms = DeepCopy(pms);
                        if (_variations[i].FFAddVMs2PMs() == 0)
                        {
                            return false;
                        }
                        else { }
                    }
                    break;
                case 1: // FF
                    for (int i = 0; i < _variations.Count; ++i)
                    {
                        _variations[i]._pms = DeepCopy(_pms);
                        if (_variations[i].FFAddVMs2PMs() == 0)
                        {
                            return false;
                        }
                        else { }
                    }
                    break;
                case 2: // GA
                    for (int i = 0; i < _variations.Count; ++i)
                    {
                        _variations[i]._pms = DeepCopy(_pms);
                        if (_variations[i].GAAddVMs2PMs(algorithm._populationsize, _variations[i]._vms.Count, _variations[i]._pms.Count, algorithm._termination, algorithm._pcrossover, algorithm._pmutation) > 0)
                        {
                            return false;
                        }
                        else { }
                    }
                    break;
                case 3: // DCGA
                    pms.Sort();
                    pms.Reverse();
                    for (int i = 0; i < _variations.Count; ++i)
                    {
                        _variations[i]._pms = DeepCopy(pms);
                        if (_variations[i].DCGAVMs2PMs(algorithm._populationsize, _variations[i]._vms.Count, algorithm._termination, algorithm._dcgasize, algorithm._pcrossover, algorithm._pmutation) > 0)
                        {
                            return false;
                        }
                        else { }
                    }
                    break;
                case 4: // FFA
                    pms.Sort();
                    pms.Reverse();
                    for (int i = 0; i < _variations.Count; ++i)
                    {
                        _variations[i]._pms = DeepCopy(pms);
                        if (_variations[i].FFAddVMs2PMs() == 0)
                        {
                            return false;
                        }
                        else { }
                    }
                    break;
            }
            return true;
        }
        public void Problematize(int numberofpms, int numberofvms, int numberofvariations, int numberofchanges, int iDuration)
        {
            _numberofpms = numberofpms;
            _numberofvms = numberofvms;
            _numberofvariations = numberofvariations;
            _numberofchanges = numberofchanges;
            _duration = iDuration;
            _pidmax = -1;
            _vidmax = -1;
            _pms.Clear();
            _vms.Clear();
            _variations.Clear();
            for (int i = 0; i < numberofpms; ++i)
            {
                _pms.Add(new PhysicalMachine());
            }
            for (int i = 0; i < numberofvms; ++i)
            {
                _vms.Add(new VirtualMachine());
            }
            List<int> times = _randomizeValues(numberofvariations, iDuration);
            List<VirtualMachine> vms = DeepCopy(_vms);
            _variations.Add(new Variation());
            _variations[0]._time = 0;
            _variations[0]._vms = DeepCopy(vms);
            int status = 1;
            for (int i = 0; i < numberofvariations; ++i)
            {
                Variation variation = new Variation();
                variation._time = times[i];
                for (int j = 0; j < numberofchanges; ++j)
                {
                    status = _random.Next(2);
                    if (status == 0)
                    {
                        VirtualMachine vmoff = vms[_random.Next(vms.Count)];
                        variation._vmsoff.Add(vmoff);
                        vms.Remove(vmoff);
                    }
                    else
                    {
                        VirtualMachine vmon = new VirtualMachine();
                        variation._vmson.Add(vmon);
                        vms.Add(vmon);
                    }
                }
                variation._vms = DeepCopy(vms);
                _variations.Add(variation);
            }
        }
        public void Load(StreamReader streamReader)
        {
            string[] sWords;
            sWords = streamReader.ReadLine().Split('\t');
            _numberofpms = int.Parse(sWords[0]);
            _numberofvms = int.Parse(sWords[1]);
            _numberofvariations = int.Parse(sWords[2]);
            _numberofchanges = int.Parse(sWords[3]);
            _duration = int.Parse(sWords[4]);
            _pidmax = -1;
            _vidmax = -1;
            _pms.Clear();
            _vms.Clear();
            _variations.Clear();
            for (int i = 0; i < _numberofpms; ++i)
            {
                sWords = streamReader.ReadLine().Split('\t');
                PhysicalMachine pm = new PhysicalMachine(int.Parse(sWords[0]), int.Parse(sWords[1]), int.Parse(sWords[2]),
                    double.Parse(sWords[3]), double.Parse(sWords[4]), double.Parse(sWords[5]), new List<VirtualMachine>());
                _pms.Add(pm);
            }
            for (int i = 0; i < _numberofvms; ++i)
            {
                sWords = streamReader.ReadLine().Split('\t');
                _vms.Add(new VirtualMachine(int.Parse(sWords[0]), int.Parse(sWords[1]), int.Parse(sWords[2])));
            }
            List<VirtualMachine> vms = DeepCopy(_vms);
            for (int i = 0; i < _numberofvariations + 1; ++i)
            {
                Variation variation = new Variation();
                sWords = streamReader.ReadLine().Split('\t');
                // Time_number of onlines_number of offlines
                variation._time = int.Parse(sWords[0]);
                int iNumberOfOfflines = int.Parse(sWords[1]);
                int iNumberOfOnlines = int.Parse(sWords[2]);
                for (int j = 0; j < iNumberOfOfflines; ++j)
                {
                    sWords = streamReader.ReadLine().Split('\t');
                    VirtualMachine vm = new VirtualMachine(int.Parse(sWords[0]), int.Parse(sWords[1]), int.Parse(sWords[2]));
                    variation._vmsoff.Add(vm);
                    vms.Remove(vm);
                }
                for (int j = 0; j < iNumberOfOnlines; ++j)
                {
                    sWords = streamReader.ReadLine().Split('\t');
                    VirtualMachine vm = new VirtualMachine(int.Parse(sWords[0]), int.Parse(sWords[1]), int.Parse(sWords[2]));
                    variation._vmson.Add(vm);
                    vms.Add(DeepCopy(vm));
                }
                variation._vms = DeepCopy(vms);
                _variations.Add(variation);
            }
        }
        public void Save(StreamWriter streamWriter)
        {
            streamWriter.AutoFlush = true;
            streamWriter.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", _numberofpms, _numberofvms, _numberofvariations, _numberofchanges, _duration);
            foreach (PhysicalMachine pm in _pms)
            {
                streamWriter.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", pm._id, pm._cpu, pm._ram, pm._emin, pm._emax, pm._k);
            }
            foreach (VirtualMachine vm in _vms)
            {
                streamWriter.WriteLine("{0}\t{1}\t{2}", vm._id, vm._cpu, vm._ram);
            }
            for (int i = 0; i < _variations.Count; ++i)
            {
                streamWriter.WriteLine("{0}\t{1}\t{2}", _variations[i]._time, _variations[i]._vmsoff.Count, _variations[i]._vmson.Count);
                for (int j = 0; j < _variations[i]._vmsoff.Count; ++j)
                {
                    streamWriter.WriteLine("{0}\t{1}\t{2}", _variations[i]._vmsoff[j]._id, _variations[i]._vmsoff[j]._cpu, _variations[i]._vmsoff[j]._ram);
                }
                for (int j = 0; j < _variations[i]._vmson.Count; ++j)
                {
                    streamWriter.WriteLine("{0}\t{1}\t{2}", _variations[i]._vmson[j]._id, _variations[i]._vmson[j]._cpu, _variations[i]._vmson[j]._ram);
                }
            }
        }
    }
}