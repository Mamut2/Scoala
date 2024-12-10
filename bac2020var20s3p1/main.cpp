#include <iostream>

using namespace std;

int pow(int x, int n)
{
    int res = 1;
    while(n)
    {
        if(n & 1) res *= x;
        x *= x;
        n = n >> 1;
    }
    return res;
}

int transformareBaza10(int b, int n)
{
    int res = 0, k = 0;
    while(n)
    {
        res += n % 10 * pow(b, k);
        n /= 10;
        k++;
    }
    return res;
}

int main()
{
    int n, b;
    cin >> b >> n;
    cout << transformareBaza10(b, n);
    return 0;
}
