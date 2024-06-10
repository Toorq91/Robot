using SimpleRobotLogic;

namespace Robot
{
    internal class Robot
    {
        private SimpleRobot simpleRobot;

        public Robot()
        {
            this.simpleRobot = new SimpleRobot();
        }

        public void GoBox()
        {
            GoThreeTimesAndTurnLeft();
            GoThreeTimesAndTurnLeft();
            GoThreeTimesAndTurnLeft();
            GoThreeTimesAndTurnLeft();
        }

        private void GoThreeTimesAndTurnLeft()
        {
            simpleRobot.Go();
            Show();
            simpleRobot.Go();
            Show();
            simpleRobot.Go();
            Show();
            simpleRobot.TurnLeft();
        }

        public void Show()
        {
            simpleRobot.Show();
        }

        public void TurnLeft()
        {
            simpleRobot.TurnLeft();
        }

        public void Go()
        {
            simpleRobot.Go();
        }

        public void TurnRight()
        {
            simpleRobot.TurnLeft();
            simpleRobot.TurnLeft();
            simpleRobot.TurnLeft();
        }

        public void GoToWall()
        {
            while (simpleRobot.Go())
            {
                Show();
            }
        }
        
    }
}
