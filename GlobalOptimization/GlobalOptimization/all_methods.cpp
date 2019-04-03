#pragma once
#include <iostream>
#inclList>
#include <map>
#include "IMethod.h"

using std::map;
using std::make_pair;

typedef map<double, double> mapP;

class TMethodOfGlobalSearch : public IMethod
{
protected:
	TFunction function;
	int r;
public:

	TMethodOfGlobalSearch(TTask *_pTask, int _r, TSearchData *_pData)
	{
		pTask = _pTask;
		pData = _pData;
		TFunction _func(pTask->str_function);
		function = _func;
		r = _r;
	}

	double function(double x)
	{
		/*return (x/4)*cos(x);*/
		return function.Calculate(x);
	}

	~TMethodOfGlobalSearch() { }

	virtual void RenewSearchData(double _x)
	{
		double _y = function(_x);
		Point tmp;
		tmp.x = _x; tmp.y = _y;
		pData->insert(tmp, root);
	}

	virtual Point CalculateOptimum()
	{
		Point result;
		double m = 1;
		double maxM = 0;
		double* M = new double[pTask->maxOfIterations];

		double* x = new double[pTask->maxOfIterations];
		double* R = new double[pTask->maxOfIterations];
		double maxR = 0;
		unsigned int maxIR = 0;

		double minF;
		double minX;

		x[0] = pTask->xl; x[1] = pTask->xr;

		if (function(x[0]) < function(x[1]))
		{
			minF = function(x[0]);
			minX = x[0];
		}
		else
		{
			minF = function(x[1]);
			minX = x[1];
		}

		for (size_t i = 1; i < pTask->maxOfIterations; i++)
		{
			for (size_t j = 0; j < i; j++)
				for (size_t l = 0; l < i - j; l++)
					if (x[l] > x[l + 1])
						std::swap(x[l], x[l + 1]);

			for (size_t j = 1; j <= i; j++)
			{
				M[j - 1] = (abs(function(x[j]) - function(x[j - 1]))) / (x[j] - x[j - 1]);
				if (M[j - 1] > maxM)
				{
					maxM = M[j - 1];
				}
			}

			if (maxM > 0)
			{
				m = r*maxM;
			}

			for (size_t j = 1; j <= i; j++)
			{
				R[j - 1] = m*(x[j] - x[j - 1]) + (pow((function(x[j]) - function(x[j - 1])), 2)) / (m*(x[j] - x[j - 1])) - 2 * (function(x[j]) + function(x[j - 1]));

				if (R[j - 1] > maxR)
				{
					maxR = R[j];
					maxIR = j;
				}
			}

			if (abs(x[maxIR] - x[maxIR - 1]) < pTask->eps)
			{
				break;
			}

			x[i + 1] = 0.5*(x[maxIR] + x[maxIR - 1]) - 0.5*(function(x[maxIR]) - function(x[maxIR - 1])) / m;
			RenewSearchData(x[i + 1]);

			if (function(x[i + 1]) < minF)
			{
				minF = function(x[i + 1]);
				minX = x[i + 1];
			}

		}
		result.x = minX;
		result.y = minF;
		return result;
	}
};

class TMethodOfPiyavsky : public IMethod
{
protected:
	double M;
	TFunction function;
	double getNextPoint(double LB, double RB)
	{
		return 0.5*(RB + LB) - 0.5*(function(RB) - function(LB)) / M;
	}
	double getIntervalCharacteristic(double LB, double RB)
	{
		return 0.5*M*(RB - LB) - 0.5*(function(RB) + function(LB));
	}
	void updateOptimum(Point& CheckingPoint, Point& Optimum)
	{
		if (CheckingPoint.y < Optimum.y)
		{
			Optimum.x = CheckingPoint.x;
			Optimum.y = CheckingPoint.y;
		}
	}
	Point& makePoint(double x)
	{
		Point tp;
		tp.x = x;
		tp.y = function(x);
		return tp;
	}
	void insertPointInData(List<double>& Data, double x)
	{
		int j = 0;
		while (x > Data[j] && j<Data.size() - 1)
			j++;
		Data.insert(Data.begin() + j, x);
	}

	virtual void RenewSearchData(double _x)
	{
		double _y = function(_x);
		Point tmp;
		tmp.x = _x; tmp.y = _y;
		pData->insert(tmp, root);
	}
	double function(double x)
	{
		return function.Calculate(x);
	}

public:

	TMethodOfPiyavsky(TTask *_pTask, double _M, TSearchData *_pData)
	{
		pTask = _pTask;
		pData = _pData;
		TFunction _func(pTask->str_function);
		function = _func;
		M = _M;
	}

	~TMethodOfPiyavsky() { }

	virtual Point CalculateOptimum()
	{
		Point result;
		Point currPoint;
		List<double> x = new List();
		int Iterations = num_of_iterations;
		double currentChara = 0;
		double currentPoint = 0;

		x.Add(pTask->xl);
		result = new makePoint(pTask->xl);
		x.Add(pTask->xr);
		currPoint = makePoint(pTask->xr);
		updateOptimum(currPoint, result);

		currentChara = getIntervalCharacteristic(pTask->xl, pTask->xr);
		currentPoint = getNextPoint(pTask->xl, pTask->xr);
		insertPointInData(x, currentPoint);
		currPoint = makePoint(currentPoint);
		updateOptimum(currPoint, result);

		int i;
		int j = 0;
		double tempJ = 0;
		double tempX;
		double tempChara;
		double gotAccuracy = pTask->xr - pTask->xl;
		for (i = 1; i < Iterations; ++i)
		{
			tempJ = 0;
			currentChara = getIntervalCharacteristic(x[0], x[1]);
			for (j = 1; j < x.size() - 1; ++j)
			{
				tempChara = getIntervalCharacteristic(x[j], x[j + 1]);
				if (tempChara > currentChara)
				{
					currentChara = tempChara;
					tempJ = j;
					gotAccuracy = x[tempJ + 1] - x[tempJ];
				}
			}
			tempX = getNextPoint(x[tempJ], x[tempJ + 1]);
			insertPointInData(x, tempX);
			RenewSearchData(tempX);
			currPoint = makePoint(tempX);
			updateOptimum(currPoint, result);
			if (pTask->eps >= gotAccuracy)
				break;
		}
		return result;
	}
};

void methodGSA()
{
	const double left_range_x = task.left_border;
	const double right_range_x = task.right_border;
    double eps = task.eps;
	int k = task.num_iter;

    const double r = 3;
	double m = 1;
	double maxM = 0;
	double M;

    struct Point
    {
        double x;
        double y;
        void operator=(const Point& p)
        {
            x = p.x;
            y = p.y;
        }
    };
	List<Point> points;
	double R;
	double maxR = 0;
	int maxIR = 0;

	Point minPoint;
    Point left_point, right_point;

    auto start_time = omp_get_wtime();

	left_point.x = left_range_x; right_point.x = right_range_x;
    left_point.y = f(left_point.x); right_point.y = f(right_point.x);
    points.Add(left_point); points.Add(right_point);

    minPoint = (left_point.y < right_point.y) ? left_point : right_point;

	for (int i = 1; i < k - 1; ++i)
	{
        std::sort(points.begin(), points.end(), [](const Point& a, const Point& b) {
            return a.x < b.x;
        });

		for (int j = 1; j <= i; ++j)
		{
			M = (fabs(points[j].y - points[j - 1].y)) / (points[j].x - points [j - 1].x);
			if (M > maxM)
			{
				maxM = M;
			}
		}

		if (maxM > 0)
		{
			m = r * maxM;
		}

		maxR = 0;
		maxIR = 1;
		for (int j = 1; j <= i; ++j)
		{
			R = m * (points[j].x - points[j - 1].x) + (pow((points[j].y - points[j - 1].y), 2))
				/ (m * (points[j].x - points[j - 1].x)) - 2 * (points[j].y + points[j - 1].y);

			if (R > maxR)
			{
				maxR = R;
				maxIR = j;
			}
		}

		if (fabs(points[maxIR].x - points[maxIR - 1].x) < eps)
		{
			break;
		}

        Point newPoint;
        newPoint.x = 0.5 * (points[maxIR].x + points[maxIR - 1].x)
                   - 0.5 * (points[maxIR].y - points[maxIR - 1].y) / m;
        newPoint.y = f(newPoint.x);
        points.Add(newPoint);

        minPoint = (newPoint.y < minPoint.y) ? newPoint : minPoint;
	}

    auto finish_time = omp_get_wtime();
    std::cout << "\n\tReport:" << std::endl;
    std::cout << "Number of iterations: "<< num_iter << std::endl;
    std::cout << "Time of working: "<< finish_time - start_time << "\n" << std::endl;

    answer.minX = minPoint.x;
    answer.minY = minPoint.y;
}

