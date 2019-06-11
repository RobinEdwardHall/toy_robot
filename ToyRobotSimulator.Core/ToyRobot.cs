using System;

namespace ToyRobotSimulator.Core
{
    public enum Directions
    {
        North,
        South,
        East,
        West
    }

    public class ToyRobot
    {
        #region Fields

        private int _x;
        private int _y;
        private Directions _f;

        private readonly int _maxX;
        private readonly int _maxY;

        private bool _isOnTableTop;

        #endregion

        #region Properties

        public int X { get => _x; }

        public int Y { get => _y; }

        public Directions F { get => _f; }

        public bool Placed { get => _isOnTableTop; }

        #endregion

        #region Constructor

        public ToyRobot(int maxX, int maxY)
        {
            _maxX = maxX;
            _maxY = maxY;

            _isOnTableTop = false;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return _isOnTableTop
                ? $"Toy robot is in position ({_x},{_y}) facing {_f.ToString()}"
                : $"Toy robot in not on table";
        }

        /// <summary>
        /// The origin (0,0) can be considered to be the SOUTH WEST most corner.
        /// MOVE will move the toy robot one unit forward in the direction it is currently facing.
        /// </summary>
        public void Move()
        {
            if (_isOnTableTop)
            {
                switch (_f)
                {
                    case Directions.North:
                        {
                            if (_y + 1 >= _maxY)
                                throw new InvalidCommandException();

                            _y = _y + 1;
                            break;
                        }
                    case Directions.South:
                        {
                            if (_y - 1 < 0)
                                throw new InvalidCommandException();

                            _y = _y - 1;
                            break;
                        }
                    case Directions.West:
                        {
                            if (_x - 1 < 0)
                                throw new InvalidCommandException();

                            _x = _x - 1;
                            break;
                        }
                    case Directions.East:
                        {
                            if (_x + 1 >= _maxX)
                                throw new InvalidCommandException();

                            _x = _x + 1;
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Will rotate the robot 90 degrees in LEFT direction without changing the position of the robot.
        /// </summary>
        public void Left()
        {
            if (_isOnTableTop)
            {
                switch (_f)
                {
                    case Directions.North:
                        _f = Directions.West;
                        break;
                    case Directions.South:
                        _f = Directions.East;
                        break;
                    case Directions.West:
                        _f = Directions.South;
                        break;
                    case Directions.East:
                        _f = Directions.North;
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Will rotate the robot 90 degrees in RIGHT direction without changing the position of the robot.
        /// </summary>
        public void Right()
        {
            if (_isOnTableTop)
            {
                switch (_f)
                {
                    case Directions.North:
                        _f = Directions.East;
                        break;
                    case Directions.South:
                        _f = Directions.West;
                        break;
                    case Directions.West:
                        _f = Directions.North;
                        break;
                    case Directions.East:
                        _f = Directions.South;
                        break;
                    default:
                        break;
                }
            }
        }

        public void Place(int x, int y, Directions f)
        {
            if (_x < 0 || _x >= _maxX)
                throw new InvalidCommandException();

            _x = x;

            if (_y < 0 || _y >= _maxY)
                throw new InvalidCommandException();

            _y = y;

            _f = f;

            if (!_isOnTableTop)
                _isOnTableTop = true;
        }

        public string Report()
        {
            return ToString();
        }

        #endregion
    }
}
