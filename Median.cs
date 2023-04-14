// Buatlah sebuah program yang dapat melakukakn input
// 11 data bilangan integer, kemudian lakukan perhitungan:
//1. Rata - rata
//2. Nilai tengah

#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
	int angka[11];
	float rata = 0;
	float median;
	
	for(int i = 0; i < 11; ++i)
	{
		cout << "Masukkan angka ke- " << i+1 << ": ";
		cin >> angka[i];
	}
	
	sort(angka, angka+11);
	
	//menampilkan
	cout << "Menampilkan : ";
	for(int i = 0; i < 11; ++i)
	{
		cout << angka[i] << " ";
	}
	
	cout << endl;
	
	//rata-rata
	for(int i = 0; i < 11; ++i)
	{
		rata += angka[i];
	}
	rata /=11;
	cout << "Rata-rata : " << rata << endl;
	
	//median
	if (11 % 2 == 0)
	{
		median = (angka[11/2] + angka[(11/2)-1]) / 2.0;
	} else 
	{
		median = angka[(11+1)/2-1];
	}
	cout << "median : " << median << endl;
	
	return 0;
}
