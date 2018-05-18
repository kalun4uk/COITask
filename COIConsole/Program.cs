using System;
using COILibraryPoint;

namespace COIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PMCDataCreator<int> pointCreatorInt = new PositionCreator<int>();
            PMCDataCreator<int> matrixCreatorInt = new PositionCreator<int>();
            PMCDataCreator<int> containerCreatorInt = new PositionCreator<int>();

            //printing to Console for 1D collections of points
            PMCDataModel<int> positionInt1D = pointCreatorInt.FactoryMethod();
            for (var i = 0; i < 10; i++)
            {
                positionInt1D.Add(new Point2D<int>(i,i));
            }
            foreach (var i in positionInt1D.GetList())
                Console.WriteLine(i.ToString());

            //printing to Console for 1D collection of collections of points
            PMCDataModel<int> matrixInt1D = pointCreatorInt.FactoryMethod();
            for (var i = 0; i < 10; i++)
            {
                matrixInt1D.Add(positionInt1D.GetList()[i]);
            }
            Console.ReadKey();
        }
    }
}
