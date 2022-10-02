using System.Collections;
using System.Numerics;

namespace Lab2plus3;

public class GeoVector : IMathVector
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    private Point _start;
    private Point _end;
    
    public Point Start => _start;
    public Point End => _end;

    public int Dimensions { get; }

    public double this[int i] {
        get
        {
            double result;
            switch (i)
            {
                case 0: result = _start.X;
                    break;
                case 1: result = _start.Y;
                    break;
                case 2: result = _end.X;
                    break;
                case 3: result = _end.Y;
                    break;
                default:
                    throw new Exception();
            }
            return result;
        }
        set
        {
            switch (i)
            {
                case 0: _start.X = value;
                    break;
                case 1: _start.Y = value;
                    break;
                case 2: _end.X = value;
                    break;
                case 3: _end.Y = value;
                    break;
                default:
                    throw new Exception();
            }
        }
    }

    public double Length { get => Math.Sqrt(Math.Pow((_end.X - _start.X), 2) + Math.Pow((_end.Y - _start.Y), 2)); }
    
    public IMathVector SumNumber(double number) 
    {
        var vecResult = new GeoVector();
        
        for (int i = 0; i < 4; ++i)
        {
            vecResult[i] = this[i] + number;
        }

        return vecResult;
    }


    public IMathVector MultiplyNumber(double number)
    {
        var vecResult = new GeoVector();
        
        for (int i = 0; i < 4; ++i)
        {
            vecResult[i] = this[i] * number;
        }

        return vecResult;
    }

    public IMathVector Sum(IMathVector vector)
    {
        var vecResult = new GeoVector();
        
        for (int i = 0; i < 4; ++i)
        {
            vecResult[i] = this[i] + vector[i];
        }

        return vecResult;
    }

    public IMathVector Multiply(IMathVector vector)
    {
        var vecResult = new GeoVector();
        
        for (int i = 0; i < 4; ++i)
        {
            vecResult[i] = this[i] * vector[i];
        }

        return vecResult;
    }

    public double ScalarMultiply(IMathVector vector, double angle)
    {
        return this.Length * vector.Length * Math.Cos(angle);
    }

    //Я буду находить среднее меджу расстояниями крайними векторами 
    public double CalcDistance(IMathVector vector)
    {
        Point vecStart = new Point(vector[0], vector[1]);
        Point vecEnd = new Point(vector[2], vector[3]);
        double distFirst = distanceCalculate(this.Start, vecStart);
        double distSecond = distanceCalculate(this.End, vecEnd);
        return (distFirst + distSecond) / 2;
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

    private double distanceCalculate(Point start, Point end)
    {
        return Math.Sqrt(Math.Pow((end.X - start.X), 2) + Math.Pow((end.Y - start.Y), 2));
    }
    
    public static IMathVector operator+ (GeoVector vector, double number)
    {
        return vector.SumNumber(number);
    }
    
    public static IMathVector operator- (GeoVector vector, double number)
    {
        return vector.SumNumber(-number);
    }
    
    public static IMathVector operator* (GeoVector vector, double number)
    {
        return vector.MultiplyNumber(number);
    }
    
    public static IMathVector operator/ (GeoVector vector, double number)
    {
        if (number == 0)
            throw new Exception();
        return vector.MultiplyNumber(1 / number);
    }
    
    public static IMathVector operator+ (GeoVector vector, GeoVector secondVec)
    {
        return vector.Sum(secondVec);
    }
    
    public static IMathVector operator- (GeoVector vector, GeoVector secondVec)
    {
        for (int i = 0; i < 4; i++)
        {
            secondVec[i] = -secondVec[i];
        }
        return vector.Sum(secondVec);
    }
    
    public static IMathVector operator* (GeoVector vector, GeoVector secondVec)
    {
        return vector.Multiply(secondVec);
    }
    
    public static IMathVector operator/ (GeoVector vector, GeoVector secondVec)
    {
        for (int i = 0; i < 4; i++)
        {
            if (secondVec[i] == 0)
                throw new Exception();

            secondVec[i] = 1 / secondVec[i];
        }
        
        return vector.Multiply(secondVec);
    }

    public static double operator% (GeoVector vector, GeoVector secondVec)
    {
        //УГЛЫ В ВЕКТОРАХ?
        double angle = 45;
        return vector.ScalarMultiply(secondVec, angle);
    }
    

}