using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Gra5x5.Program;

namespace GameUnitTest
{
    [TestClass]
    public class GameUnitTest
    {
        [TestMethod]
        public void TestStartAndEndAreOnDifferentFields()
        {
            Game game = new Game();
            int startX = game.GetStartX();
            int startY = game.GetStartY();
            int endX = game.GetEndX();
            int endY = game.GetEndY();

            Assert.AreNotEqual(startX, endX);
            Assert.AreNotEqual(startY, endY);
        }

        [TestMethod]
        public void TestMapHasObstacles()
        {
            Game game = new Game();
            int[,] map = game.GetMap();

            int obstaclesCount = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (map[i, j] == 1)
                    {
                        obstaclesCount++;
                    }
                }
            }

            Assert.IsTrue(obstaclesCount > 0);
        }
    }
}
