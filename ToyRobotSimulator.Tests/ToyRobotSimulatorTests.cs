using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobotSimulator.Core;

namespace ToyRobotSimulator.Tests
{
    [TestClass]
    public class ToyRobotSimulatorTests
    {
        [TestMethod]
        public void TestLeftCommand()
        {
            // Arrange

            ToyRobot tRobot = new ToyRobot(5, 5);
            tRobot.Place(0, 0, Directions.North);

            // Act

            tRobot.Left();

            // Assert

            Assert.AreEqual(Directions.West, tRobot.F);
        }

        [TestMethod]
        public void TestValidMoveCommand()
        {
            // Arrange

            ToyRobot tRobot = new ToyRobot(5, 5);
            tRobot.Place(0, 0, Directions.North);

            // Act

            tRobot.Move();

            // Assert

            Assert.AreEqual(Directions.North, tRobot.F);
            Assert.AreEqual(0, tRobot.X);
            Assert.AreEqual(1, tRobot.Y);
        }

        [TestMethod]
        public void TestInvalidMoveCommand()
        {
            // Arrange

            ToyRobot tRobot = new ToyRobot(5, 5);
            tRobot.Place(0, 4, Directions.North);

            try
            {
                // Act

                tRobot.Move();

            }
            catch (InvalidCommandException)
            {
            }

            // Assert

            Assert.AreEqual(Directions.North, tRobot.F);
            Assert.AreEqual(0, tRobot.X);
            Assert.AreEqual(4, tRobot.Y);
        }

        [TestMethod]
        public void TestPlaceAsFirstCommand()
        {
            // Arrange

            ToyRobot tRobot = new ToyRobot(5, 5);

            try
            {
                // Act

                tRobot.Move();

            }
            catch (InvalidCommandException)
            {
            }

            // Assert

            Assert.AreEqual(false, tRobot.Placed);
        }
    }
}
