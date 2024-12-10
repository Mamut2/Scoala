#include <iostream>

using namespace std;

int factori(int n, int m)
{
    int d = 2, p1, p2, nr = 0;
    while(n > 1 && m > 1)
    {
        p1 = p2 = 0;
        while(n % d == 0 && n > 1) n/=d, p1++;
        while(m % d == 0 && m > 1) m/=d, p2++;
        d++;
        if(p1 == p2 && p1 != 0) nr++;
    }
    return nr;
}

int main()
{
    int x, y;
    cin >> x >> y;
    cout << factori(x, y);
    return 0;
}
