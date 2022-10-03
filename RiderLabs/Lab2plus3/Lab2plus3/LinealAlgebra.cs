using System.Collections;
using System.Numerics;
using System.Math;

//namespace Lab2plus3;

public class GeoVector : Object, IMathVector
{
    private List<double> _osi = new List<double>();
    
    public int Dimensions { get => _osi.Length(); }

    public double this[int i] {
        get
        {
            if (i < 0 || i >= _osi.Length())
                throw new Exception();

            return _osi[i];
        }
        set
        {
            if (i < 0 || i >= _osi.Length())
                throw new Exception();

            _osi[i] = value;
        }
        
    }

    public double Length
    {
        get
        {
            double sum = 0;
            foreach (var pos in _osi)
            {
                sum += Math.Pow(pos, 2);
            }
            return Math.Sqrt(sum);
        }
        
    }
    
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

    public double ScalarMultiply(IMathVector vector)
    {
        //Я либо дурак, либо слепой. Я не понимаю, как тут угл без угла найти
        return this.Length * vector.Length;
    }
 
    public double CalcDistance(IMathVector vector)
    {
        double result = 0;
        for (int i =0; i < _osi.Length(); ++i)
        {
            result += (Math.Pow(this[i], 2) - Math.Pow(vector[i], 2));
        }
        return Math.Sqrt(result);
    }

    public IEnumerator GetEnumerator() => _osi.GetEnumerator();
    
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
        return vector.ScalarMultiply(secondVec);
    }
    

}