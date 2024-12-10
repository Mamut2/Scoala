#include <iostream>

using namespace std;

void pao(int x, int y, int &rez)
{
    rez = 1;
    int temp = 0, p = 1;
    while(x != 0)
    {
        if(x % 10 % 2 == 0 && x % 10 != 0)
        {
            temp = temp + p * (x % 10);
            p *= 10;
        }
        x /= 10;
    }
    x = temp;
    temp = 0;
    while(y != 0)
    {
        if(y % 10 % 2 == 0 && y % 10 != 0)
        {
            temp = 10 * temp + y % 10;
        }
        y /= 10;
    }
    y = temp;
    if(x == 0 || y == 0) rez = 0;
    while(x > 0 && y > 0)
    {
        if(x % 10 != y % 10) rez = 0;
        x /= 10, y /= 10;
    }
}

int main()
{
    int x, y, rez;
    cin >> x >> y;
    pao(x, y, rez);
    cout << rez;
    return 0;
}
