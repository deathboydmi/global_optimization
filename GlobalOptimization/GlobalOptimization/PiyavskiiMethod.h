#pragma once
#pragma once
#include <iostream>
#include <set>
#include <vector>


class PiyavskiiMethod
{
	double mParam;
	double rParam;

	int leftBound;
	int rightBound;

	std::vector<double> characteristics; // R_i
	std::set<double> points; // x_k
	std::vector<double> funcValues; // z_k

public:

	std::vector<double> GetPoints()
	{ 
		std::vector<double> p;
		std::set<double>::iterator it;

		for (it = points.begin(); it != points.end(); ++it)
			p.push_back(*it);
		return p;
	}

	PiyavskiiMethod(double _mParam, double _rParam, double _leftBound, double _rightBound) : mParam(_mParam), rParam(_rParam),
		leftBound(_leftBound), rightBound(_rightBound)
	{
		points.insert(_leftBound);
		points.insert(_rightBound);
	}

	~PiyavskiiMethod() {};


	int getBestCharactIndex() {
		int index = 0;

		for (int i = 0; i < characteristics.size(); i++) {
			if (characteristics[i] > characteristics[index])
				index = i;
		}

		return index;
	}

	void calcCharact(double alpha, double betta, double gamma, double delta)
	{
		characteristics.clear();
		funcValues.clear();
		std::vector<double> p;
		std::set<double>::iterator it;

		for (it = points.begin(); it != points.end(); ++it)
			p.push_back(*it);

		for (int i = 0; i < p.size(); i++)
			functionValues(p[i], alpha, betta, gamma, delta);

		for (int i = 0; i < points.size() - 1; i++)
		{
			characteristics.push_back(calcCharact(i, alpha, betta, gamma, delta));
		}
	}

	void Print()
	{
		//std::cout << "Points " << std::endl;
		std::set<double>::iterator it;
		for (it = points.begin(); it != points.end(); ++it)
		{
			std::cout << *it << std::endl;
		}
		//std::cout << std::endl;
		//std::cout << "FuncValues " << std::endl;
		for (int i = 0; i < funcValues.size(); i++)
		{
			std::cout << funcValues[i] << std::endl;
		}
	}

	double calcCharact(int i, double alpha, double betta, double gamma, double delta)
	{
		std::vector<double> p;
		std::set<double>::iterator it;

		for (it = points.begin(); it != points.end(); ++it)
			p.push_back(*it);

		double M = 0.0;


		for (int i = 0; i < points.size() - 1; ++i)
		{
			double deltaZ = fabs(funcValues[i + 1] - funcValues[i]);
			double deltaX = p[i + 1] - p[i];
			double newM = deltaZ / deltaX;

			if (newM > M)
				M = newM;
		}
		mParam = M > 0 ? rParam * M : 1;
		return 0.5 * (mParam * (p[i + 1] - p[i]) - funcValues[i + 1] - funcValues[i]);
	}

	double calcNextPoint()
	{
		std::vector<double> p;
		std::set<double>::iterator it;

		int index = getBestCharactIndex();

		for (it = points.begin(); it != points.end(); ++it)
			p.push_back(*it);

		return 0.5 * (p[index + 1] + p[index] - (funcValues[index + 1] - funcValues[index]) / mParam);
	}

	double func(double x, double alpha, double betta, double gamma, double delta)
	{
		return alpha * sin(betta * x) + gamma * cos(delta * x);
	}

	void updateFunctionValues(double alpha, double betta, double gamma, double delta)
	{
		std::set<double>::iterator it;

		for (it = points.begin(); it != points.end(); ++it)
		{
			funcValues.push_back(func(*it, alpha, betta, gamma, delta));
		}
	}

	double functionValues(double index, double alpha, double betta, double gamma, double delta)
	{
		funcValues.push_back(func(index, alpha, betta, gamma, delta));
		return func(index, alpha, betta, gamma, delta);
	}

	void getArgmin(int& argminInd, double& funcminInd)
	{
		for (int i = 0; i < funcValues.size(); i++)
			if (funcValues[i] < funcValues[argminInd])
				argminInd = i;
		funcminInd = funcValues[argminInd];
	}

	void processStep(int& count, double alpha, double betta, double gamma, double delta, int countItNum, double eps)
	{
		double currArgValue = 0.0;
		double prevArgValue = 0.0;
		double currFuncValue = 0.0;

		updateFunctionValues(alpha, betta, gamma, delta);
		do
		{
			calcCharact(alpha, betta, gamma, delta);

			prevArgValue = currArgValue;
			currArgValue = calcNextPoint();
			points.insert(currArgValue);

			count++;
		} while (fabs(currArgValue - prevArgValue) > eps && count < countItNum);

	}
};



const int N=26;
const double M=180;
double func(double x)
{
double y;
y=pow(x,4)-8*pow(x,3)-8*pow(x,2)+96*x-3;
return y;
}
int minpos(double a[N+1], int n)
{
  int imin;
  double min;
  imin=1;
  min=a[1];
  for (int i=2; i<=n; i++)
  {
     if (a[i]<min)
     {
       min=a[i];
       imin=i;
     }
  }
  return imin;
}
double min(double a[N+1],int n)
{
  double min;
  min=a[1];
  for (int i=2; i<=n; i++)
  {
     if (a[i]<min)
     {
       min=a[i];
     }
  }
  return min;
}
double InterPoint(double InterPoint[3],double x1, double y1, double x2, double y2)
{
 double Temp;
 Temp = (y1 - y2)/(2*M) + (x1 + x2)/2;
 InterPoint[1] = Temp;
 InterPoint[2] = y1 + M*x1 - M*Temp;
 return *InterPoint;
}
 
int main(int argc, char* argv[])
{
	double a=-3, b=7;
	double x[N+1];
	double y[N+1];
	double ymin;
	int i, imin, j;
	printf ("Metod perebora:\n");
	for (i=1;i<=N;i++)
	{
		x[i]=a+(2*i-1)*(b-a)/(2*N);
	}
	for (i=1; i<=N; i++)
		y[i]=func(x[i]);
	ymin=y[1];
	for (i=1; i<=N; i++)
	{
		if (y[i]<=ymin)
		{
			ymin=y[i];
			imin=i;
		}
	}
	printf("Naim. znacheniye f: %f\n\n", ymin);
	printf ("Metod lomanyh:\n");
	double Theor, Fact;
	double Inter[3];
	double minPhix[N], minPhiy[N]; 
	
	int minNum;
	x[1] = a;
	x[2] = b;
	y[1] = func(x[1]);
	y[2] = func(x[2]);
	InterPoint(Inter,x[1], y[1], x[2], y[2]);
	minPhix[1] = Inter[1];
	minPhiy[1] = Inter[2];
	for( i = 3; i<=N;i++)
	{
	minNum = minpos(minPhiy,i-2);
	for(j = 1;j<=(i-minNum-1);j++)
	{
		x[i-j+1] = x[i-j];
		y[i-j+1] = y[i-j];
	}
	x[minNum+1] = minPhix[minNum];
	y[minNum+1] = func(x[minNum+1]);
	for (j = 1; j<=(i-minNum-1); j++)
	{
		minPhix[i-j] = minPhix[i-j-1];
		minPhiy[i-j] = minPhiy[i-j-1];
	}
	InterPoint(Inter,x[minNum], y[minNum], x[minNum+1], y[minNum+1]);
	minPhix[minNum] = Inter[1];
	minPhiy[minNum] = Inter[2];
	InterPoint(Inter,x[minNum+1], y[minNum+1], x[minNum+2], y[minNum+2]);
	minPhix[minNum+1] = Inter[1];
	minPhiy[minNum+1] = Inter[2];
	}
	ymin = min(y,N);
	Fact = fabs(ymin-(-147));
	Theor = ymin - min(minPhiy,N);
	printf("Naim. znacheniye f: %f\n", ymin);
	printf("Theor. precision is: %f\n", Theor);
	printf("Fact. precision is: %f\n", Fact);
	getch();
	return 0;

}