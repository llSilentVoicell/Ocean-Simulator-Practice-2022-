using OceanLib.CustomExceptions;
using OceanLib.Interfaces;
using System;
using System.Windows.Forms;

namespace OceanLib
{
    public class Ocean : IOceanCell
    {
        #region [Variables]

        public Cell[,] cells;

        private static int _numRows = Constants.MaxRows;
        private static int _numCols = Constants.MaxCols;

        private const int _size = Constants.MaxRows * Constants.MaxCols;

        private bool _isConsole;

        private int _numPrey = Constants.DefaultNumPrey;
        private int _numPredators = Constants.DefaultNumPredators;
        private int _numObstacles = Constants.DefaultNumObstacles;

        public static Randomize random;
        private IAdd _addCells;
        private ExceptionInform _inform = new ExceptionInform();

        #endregion

        #region [Properties]

        public int NumPrey
        {
            get { return _numPrey; }

            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new InvalidValueForObjectsException();
                    }
                    else if (value >= _size)
                    {
                        throw new InvalidValueForObjectsException("The amount of preys cannot be greater than the size of the ocean.");
                    }
                    else
                    {
                        _numPrey = value;
                    }
                }
                catch (InvalidValueForObjectsException ex)
                {
                    _inform.Inform(ex.Message);
                    
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    _inform.Inform(ex.Message);
                    
                    Environment.Exit(0);
                }
            }
        }

        public int NumPredators
        {
            get { return _numPredators; }

            set 
            {
                try
                {
                    if (value < 0)
                    {
                        throw new InvalidValueForObjectsException();
                    }
                    else if (value >= _size)
                    {
                        throw new InvalidValueForObjectsException("The amount of predators cannot be greater than the size of the ocean.");
                    }
                    else
                    {
                        _numPredators = value;
                    }
                }
                catch (InvalidValueForObjectsException ex)
                {
                    _inform.Inform(ex.Message);
                    
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    _inform.Inform(ex.Message);
                    
                    Environment.Exit(0);
                }
            }
        }

        public int NumObstacles
        {
            get { return _numObstacles; }

            set 
            {
                try
                {
                    if (value < 0)
                    {
                        throw new InvalidValueForObjectsException();
                    }
                    else if (value >= _size)
                    {
                        throw new InvalidValueForObjectsException("The amount of obstacles cannot be greater than the size of the ocean.");
                    }
                    else
                    {
                        _numObstacles = value;
                    }
                }
                catch (InvalidValueForObjectsException ex)
                {
                    _inform.Inform(ex.Message);
                    
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    _inform.Inform(ex.Message);
                    
                    Environment.Exit(0);
                }
            }
        }

        public int NumRows
        {
            get { return _numRows; }

            set 
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new InvalidRowsValueException();
                    }
                    else if (value > Constants.MaxRows)
                    {
                        throw new InvalidRowsValueException("The number of rows value is too big.");
                    }
                    else
                    {
                        _numRows = value;
                    }
                }
                catch (InvalidRowsValueException ex)
                {
                    _inform.Inform(ex.Message);
                    
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    _inform.Inform(ex.Message);
                    
                    Environment.Exit(0);
                }
            }
        }

        public int NumCols
        {
            get { return _numCols; }

            set 
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new InvalidColumnsValueException();
                    }
                    else if (value > Constants.MaxCols)
                    {
                        throw new InvalidColumnsValueException("The number of columns value is too big.");
                    }
                    else
                    {
                        _numCols = value;
                    }
                }
                catch (InvalidColumnsValueException ex)
                {
                    _inform.Inform(ex.Message);
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    _inform.Inform(ex.Message);
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }

        public Cell[,] Cells
        {
            get { return cells; }
        }

        #endregion

        #region [Constructor]

        public Ocean(bool isConsole)
        {
            _isConsole = isConsole;
            _inform.RegisterHandler(PrintExceptionMessage);
        }

        #endregion

        #region [Methods]

        /// <summary>
        /// The method responsible for the generation of ocean elements.
        /// </summary>
        /// <param name="oceanView">The parameter is used to access the data entered by the user.</param>
        public void Initialize(IOceanView oceanView)
        {
            CheckValues();

            cells = new Cell[_numRows, _numCols];
            random = new Randomize();
            _addCells = new AddCells();

            InitializeCells(oceanView);
        }

        private void CheckValues()
        {
            int sumObjects;

            NumPrey = _numPrey;
            NumPredators = _numPredators;
            NumObstacles = _numObstacles;

            NumRows = _numRows;
            NumCols = _numCols;

            try
            {
                sumObjects = NumPrey + NumPredators + NumObstacles;

                if (sumObjects >= _size)
                {
                    throw new OceanOverflowException();
                }
            }
            catch (OceanOverflowException ex)
            {
                _inform.Inform(ex.Message);

                Environment.Exit(0);
            }
        }

        private void InitializeCells(IOceanView oceanView)
        {
            _numPrey = oceanView.UserNumPrey;
            _numPredators = oceanView.UserNumPredators;
            _numObstacles = oceanView.UserNumObstacles;
            
            _addCells.AddAllCells(this);
        }

        /// <summary>
        /// The method in which the behavior of ocean elements is processed.
        /// </summary>
        /// <param name="iteration">The parameters we use to pass information about the current iteration number.</param>
        public void Run(int iteration)
        {
            for (int i = 0; i < _numRows; i++)
            {
                for (int j = 0; j < _numCols; j++)
                {
                    cells[i, j].wasNotProcessed = true;
                }
            }
            
            for (int i = 0; i < _numRows; i++)
            {
                for (int j = 0; j < _numCols; j++)
                {
                    cells[i, j].Process(iteration);
                }
            } 
        }

        private void PrintExceptionMessage(string message)
        {
            if (_isConsole)
            {
                Console.WriteLine(message);
                Console.ReadKey();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        #endregion  
    }
}
