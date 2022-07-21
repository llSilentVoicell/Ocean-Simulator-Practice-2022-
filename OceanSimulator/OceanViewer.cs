using OceanLib;
using System;
using OceanLib.Interfaces;
using OceanLib.CustomExceptions;

namespace OceanSimulator
{
    class OceanViewer : IOceanView, IEnterDisplayData
    {
        #region [Variables]

        private const int _maxObjects = Constants.MaxRows * Constants.MaxCols;
        private int _sumOfObjects;
        private bool _isConverted;

        private int _numIterations;

        public int numOfOceans;

        private int _numPrey;
        private int _numPredators;
        private int _numObstacles;

        private int _lastIterationRows = Constants.MaxRows + 3;
        private int _lastIterationCols = Constants.MaxCols + 4;

        private char[,] _lastIterationImage;
        private char[,] _newIterationImage;
        private string _updatedStats;

        private ExceptionInform _inform = new ExceptionInform();

        private ElementsForDisplay _getImage = new ElementsForDisplay();

        #endregion

        #region [Properties]

        public int UserNumPrey
        {
            get { return _numPrey; }
            set { _numPrey = value; }
        }

        public int UserNumPredators
        {
            get { return _numPredators; }
            set { _numPredators = value; }
        }

        public int UserNumObstacles
        {
            get { return _numObstacles; }
            set { _numObstacles = value; }
        }

        public int UserNumIteration
        {
            get { return _numIterations; }
            set { _numIterations = value; }
        }

        #endregion

        #region [Constructor]

        public OceanViewer()
        {
            _inform.RegisterHandler(PrintExceptionMessage);
        }

        #endregion

        #region [Data entry]

        public void SetNumOfOceans()
        {
            try
            {
                Console.Write("Enter a number of ocean simulations (enter 1 or 2): ");

                numOfOceans = Int32.Parse(Console.ReadLine());

                if(numOfOceans <= 0 || numOfOceans > 2)
                {
                    throw new OceanNumException();
                }
            }
            catch(OceanNumException ex)
            {
                _inform.Inform(ex.Message);
                SetNumOfOceans();
            }
            catch (Exception ex)
            {
                _inform.Inform(ex.Message);
                SetNumOfOceans();
            }
        }

        public void EnterNumOfObjects(int oceanNumber, IOceanView view)
        {
            Console.Clear();

            if (oceanNumber == 1)
            {
                Console.WriteLine("\n\t|| Enter the parameters for the first ocean ||\n");
            }

            if (oceanNumber == 2)
            {
                Console.WriteLine("\n\t|| Enter the parameters for the second ocean ||\n");
            }

            _isConverted = false;

            while (!_isConverted)
            {
                try
                {
                    Console.Write("Enter a number of preys (default -> 150): ");

                    _numPrey = Int32.Parse(Console.ReadLine());

                    if(_numPrey <= 0)
                    {
                        throw new InvalidValueForObjectsException();
                    }
                    else if(_numPrey >= _maxObjects)
                    {
                        throw new InvalidValueForObjectsException("The amount of preys cannot be greater than the size of the ocean.");
                    }
                    else
                    {
                        _isConverted = true;
                    }
                }
                catch (InvalidValueForObjectsException ex)
                {
                    _inform.Inform(ex.Message);
                }
                catch (Exception ex)
                {
                    _inform.Inform(ex.Message);
                }
            }

            _isConverted = false;

            while (!_isConverted)
            {
                try
                {
                    Console.Write("Enter a number of predators (default -> 20): ");

                    _numPredators = Int32.Parse(Console.ReadLine());

                    if (_numPredators <= 0)
                    {
                        throw new InvalidValueForObjectsException();
                    }
                    else if (_numPredators >= _maxObjects)
                    {
                        throw new InvalidValueForObjectsException("The amount of predators cannot be greater than the size of the ocean.");
                    }
                    else
                    {
                        _isConverted = true;
                    }
                }
                catch (InvalidValueForObjectsException ex)
                {
                    _inform.Inform(ex.Message);
                }
                catch (Exception ex)
                {
                    _inform.Inform(ex.Message);
                }
            }

            _isConverted = false;

            while (!_isConverted)
            {
                try
                {
                    Console.Write("Enter a number of obstacles (default -> 75): ");

                    _numObstacles = Int32.Parse(Console.ReadLine());

                    if (_numObstacles <= 0)
                    {
                        throw new InvalidValueForObjectsException();
                    }
                    else if (_numObstacles >= _maxObjects)
                    {
                        throw new InvalidValueForObjectsException("The amount of obstacles cannot be greater than the size of the ocean.");
                    }
                    else
                    {
                        _isConverted = true;
                    }
                }
                catch (InvalidValueForObjectsException ex)
                {
                    _inform.Inform(ex.Message);
                }
                catch (Exception ex)
                {
                    _inform.Inform(ex.Message);
                }
            }

            try
            {
                _sumOfObjects = _numPrey + _numPredators + _numObstacles;

                if (_sumOfObjects >= _maxObjects)
                {
                    throw new OceanOverflowException(); 
                }

            }
            catch (OceanOverflowException ex)
            {
                _inform.Inform(ex.Message);
                Console.WriteLine("The maximum allowable number of objects has been exceeded (Maximum Allowed Number of Objects -> {0})", _maxObjects);
                EnterNumOfObjects(oceanNumber, view);
            }

            view.UserNumPrey = this.UserNumPrey;
            view.UserNumPredators = this.UserNumPredators;
            view.UserNumObstacles = this.UserNumObstacles;
        }

        public void EnterNumOfIterations(IOceanView view)
        {
            try
            {
                Console.Write("Enter a number of iterations (Maximum Allowed Number of Iterations -> {0})", Constants.DefaultNumIterations);

                _numIterations = Int32.Parse(Console.ReadLine());

                if (_numIterations <= 0 || _numIterations > Constants.DefaultNumIterations)
                {
                    throw new InvalidInputIterationsException();
                }
            }
            catch (InvalidInputIterationsException ex)
            {
                _inform.Inform(ex.Message);
                EnterNumOfIterations(view);
            }
            catch(Exception ex)
            {
                _inform.Inform(ex.Message);
                EnterNumOfIterations(view);
            }

            view.UserNumIteration = this.UserNumIteration;
        }

        #endregion

        #region [Display]

        public void Display(int iteration, Ocean owner, int oceanNumber, int numIterations)
        {
            _lastIterationImage = new char[_lastIterationRows, _lastIterationCols];
            _newIterationImage = new char[_lastIterationRows, _lastIterationCols];

            _updatedStats = String.Format("Iteration: {0}/{1}     Obstacles: {2}" +
                "     Prey: {3}     Predators: {4}", iteration + 1, numIterations,
                owner.NumObstacles, owner.NumPrey, owner.NumPredators);


            _newIterationImage = _getImage.GetIterationImage(_newIterationImage, _updatedStats, owner, _lastIterationRows, _lastIterationCols);

            if (oceanNumber == 1)
            {
                for (int i = 0; i < _lastIterationRows; i++)
                {
                    for (int j = 0; j < _lastIterationCols; j++)
                    {
                        if (_newIterationImage[i, j] != _lastIterationImage[i, j])
                        {
                            Console.SetCursorPosition(j, i);
                            Console.Write(_newIterationImage[i, j]);
                        }
                    }
                }
            }

            if (oceanNumber == 2)
            {
                for (int i = 0; i < _lastIterationRows; i++)
                {
                    for (int j = 0; j < _lastIterationCols; j++)
                    {
                        if (_newIterationImage[i, j] != _lastIterationImage[i, j])
                        {
                            int d = j + 80;

                            Console.SetCursorPosition(d, i);
                            Console.Write(_newIterationImage[i, j]);
                        }
                    }
                }
            }

            _lastIterationImage = _getImage.GetIterationImage(_lastIterationImage, _updatedStats, owner, _lastIterationRows, _lastIterationCols);
        }

        public void EndSimulation(int oceanNumber)
        {
            if (oceanNumber == 1)
            {
                Console.SetCursorPosition(14, _lastIterationRows + 2);
                Console.WriteLine(">=====| The simulation is complete |=====<");
                Console.WriteLine();
            }

            if (oceanNumber == 2)
            {
                Console.SetCursorPosition(94, _lastIterationRows + 2);
                Console.WriteLine(">=====| The simulation is complete |=====<");
                Console.WriteLine();
            }
        }

        public void CloseApp(int oceanNumber)
        {
            if (oceanNumber == 1)
            {
                Console.SetCursorPosition(10, _lastIterationRows + 5);
                Console.WriteLine(">=====| Press any key to  close the window |=====<");
                Console.WriteLine();
                Console.ReadKey();
            }

            if (oceanNumber == 2)
            {
                Console.SetCursorPosition(50, _lastIterationRows + 5);
                Console.WriteLine(">=====| Press any key to  close the window |=====<");
                Console.WriteLine();
                Console.ReadKey();
            }
        }

        void PrintExceptionMessage(string message)
        {
            Console.WriteLine(message);
        }

        #endregion
    }
}
