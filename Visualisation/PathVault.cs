using System.Drawing;
using System.Linq;
using WinFormAnimation_NET5;

namespace Visualisation
{
    public static class PathVault
    {
        private static readonly Point StartPoint = new(233, 230);
        private static readonly Point CouchPoint = new(175, 305);
        private static readonly Point DishPoint = new(115, 95);
        private static readonly Point PoopPoint = new(345, 275);
        private static readonly Point EnterPoopPoint = new(315, 230);
        private static readonly Point YaePoint = new(325, 15);
        private static readonly Point LoungePoint = new(220, 15);

        public static Path2D[] GetPathFromAToB(Point A, Point B)
        {
            return new Path2D
            (
                new Path(A.X, B.X, 200),
                new Path(A.Y, A.Y, 200)
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(B.X, B.X, 200),
                    new Path(A.Y, B.Y, 200)
                )
            );
        }
        
        public static readonly Path2D[] StayDish =
            new Path2D
            (
                new Path(DishPoint.X, DishPoint.X, 200),
                new Path(DishPoint.Y, DishPoint.Y, 200)
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(DishPoint.X, DishPoint.X, 200),
                    new Path(DishPoint.Y, DishPoint.Y, 200)
                )
            );
        
        public static readonly Path2D[] StayYae =
            new Path2D
            (
                new Path(YaePoint.X - 40, YaePoint.X - 40, 200),
                new Path(YaePoint.Y, YaePoint.Y, 200)
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(YaePoint.X - 40, YaePoint.X - 40, 200),
                    new Path(YaePoint.Y, YaePoint.Y, 200)
                )
            );

        public static readonly Path2D[] FromStartToYae =
            new Path2D
            (
                new Path(StartPoint.X, StartPoint.X, 200),
                new Path(StartPoint.Y, YaePoint.Y, 200)
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(StartPoint.X, YaePoint.X - 40, 200),
                    new Path(YaePoint.Y, YaePoint.Y, 200)
                )
            );

        public static readonly Path2D[] FromYaeToStart =
            new Path2D
            (
                new Path(YaePoint.X - 40, StartPoint.X, 200),
                new Path(YaePoint.Y, YaePoint.Y, 200)
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(StartPoint.X, StartPoint.X, 200),
                    new Path(YaePoint.Y, StartPoint.Y, 200)
                )
            );


        public static readonly Path2D[] FromYaeToDish =
            new Path2D
            (
                new Path(YaePoint.X, LoungePoint.X, 200),
                new Path(YaePoint.Y, YaePoint.Y, 200)
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(LoungePoint.X, LoungePoint.X, 200),
                    new Path(LoungePoint.Y, DishPoint.Y, 200)
                )
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(LoungePoint.X, DishPoint.X, 200),
                    new Path(DishPoint.Y, DishPoint.Y, 200)
                )
            );

        public static readonly Path2D[] FromDishToYae =
            new Path2D
            (
                new Path(DishPoint.X, LoungePoint.X, 200),
                new Path(DishPoint.Y, DishPoint.Y, 200)
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(LoungePoint.X, LoungePoint.X, 200),
                    new Path(DishPoint.Y, LoungePoint.Y, 200)
                )
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(LoungePoint.X, YaePoint.X, 200),
                    new Path(LoungePoint.Y, LoungePoint.Y, 200)
                )
            );

        public static readonly Path2D[] StayStart =
            new Path2D
            (
                new Path(StartPoint.X, StartPoint.X, 200),
                new Path(StartPoint.Y, StartPoint.Y, 200)
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(StartPoint.X, StartPoint.X, 200),
                    new Path(StartPoint.Y, StartPoint.Y, 200)
                )
            );

        public static readonly Path2D[] FromCouchToStart =
            new Path2D
            (
                new Path(CouchPoint.X, CouchPoint.X, 200),
                new Path(CouchPoint.Y, StartPoint.Y, 200)
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(CouchPoint.X, StartPoint.X, 200),
                    new Path(StartPoint.Y, StartPoint.Y, 200)
                )
            );

        public static readonly Path2D[] FromStartToCouch =
            new Path2D
            (
                new Path(StartPoint.X, CouchPoint.X, 200),
                new Path(StartPoint.Y, StartPoint.Y, 200)
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(CouchPoint.X, CouchPoint.X, 200),
                    new Path(StartPoint.Y, CouchPoint.Y, 200)
                )
            );

        public static readonly Path2D[] FromPoopToStart =
            new Path2D
            (
                new Path(PoopPoint.X, EnterPoopPoint.X, 200),
                new Path(PoopPoint.Y, PoopPoint.Y, 200)
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(EnterPoopPoint.X, EnterPoopPoint.X, 200),
                    new Path(PoopPoint.Y, EnterPoopPoint.Y, 200)
                )
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(EnterPoopPoint.X, StartPoint.X, 200),
                    new Path(EnterPoopPoint.Y, StartPoint.Y, 200)
                )
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(StartPoint.X, StartPoint.X, 200),
                    new Path(StartPoint.Y, StartPoint.Y, 200)
                )
            );

        public static readonly Path2D[] FromStartToPoop =
            new Path2D
            (
                new Path(StartPoint.X, StartPoint.X, 200),
                new Path(StartPoint.Y, StartPoint.Y, 200)
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(StartPoint.X, EnterPoopPoint.X, 200),
                    new Path(StartPoint.Y, EnterPoopPoint.Y, 200)
                )
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(EnterPoopPoint.X, EnterPoopPoint.X, 200),
                    new Path(EnterPoopPoint.Y, PoopPoint.Y, 200)
                )
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(EnterPoopPoint.X, PoopPoint.X, 200),
                    new Path(PoopPoint.Y, PoopPoint.Y, 200)
                )
            );

        public static readonly Path2D[] FromStartToDish =
            new Path2D
            (
                new Path(StartPoint.X, StartPoint.X, 200),
                new Path(StartPoint.Y, DishPoint.Y, 200)
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(StartPoint.X, DishPoint.X, 200),
                    new Path(DishPoint.Y, DishPoint.Y, 200)
                )
            );

        public static readonly Path2D[] FromDishToStart =
            new Path2D
            (
                new Path(DishPoint.X, StartPoint.X, 200),
                new Path(DishPoint.Y, DishPoint.Y, 200)
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(StartPoint.X, StartPoint.X, 200),
                    new Path(DishPoint.Y, StartPoint.Y, 200)
                )
            );

        public static readonly Path2D[] FromCouchToEat =
            new Path2D
            (
                new Path(CouchPoint.X, CouchPoint.X, 200),
                new Path(CouchPoint.Y, StartPoint.Y, 200)
            ).ContinueTo
            (
                new Path2D
                (
                    new Path(CouchPoint.X, StartPoint.X, 200),
                    new Path(StartPoint.Y, StartPoint.Y, 200)
                ).ContinueTo
                (
                    new Path2D
                    (
                        new Path(StartPoint.X, StartPoint.X, 200),
                        new Path(StartPoint.Y, DishPoint.Y, 200)
                    )
                ).ContinueTo
                (
                    new Path2D
                    (
                        new Path(StartPoint.X, DishPoint.X, 200),
                        new Path(DishPoint.Y, DishPoint.Y, 200)
                    )
                )
            );
    }
}