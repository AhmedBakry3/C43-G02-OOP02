namespace Assignment_Session_2_OOP
{
    internal struct Rectangle
    {
        #region Attributes
        private double width;
        private double height;
        #endregion

        #region Properties
        public double Width // Propety for Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                    width = value;
                else
                    Console.WriteLine("Width cannot be negative");
            }
        }

        public double Height //Property For Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;
                else
                    Console.WriteLine("Height cannot be negative");
            }
        }

        public double Area //Read Only Property
        {
            get { return width * height; }
        }
        #endregion

        #region Method
        public void DisplayInfo()
        {
            Console.WriteLine($"Width: {width}, Height: {height}, Area: {Area}");
        }
        #endregion
    }
}
