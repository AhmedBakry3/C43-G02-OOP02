namespace Assignment_Session_2_OOP
{
    internal struct Point
    {
        #region Attributes
        public double X {  get; set; }  
        public double Y { get; set; }
        #endregion 

        #region Constructor
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region Methods
        public override string ToString() //override the tostring() method
        {
            return $"({X}, {Y})";
        }
        public static double CalculateDistance(Point p1, Point p2) // Method to calulate the distance between Two Points
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
        #endregion
    }
}
