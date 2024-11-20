#include <iostream>
#include <cstring>

using namespace std;

char s[10001], temp[200001], voc[] = {'a', 'e', 'i', 'o', 'u'};
bool ok = 1;
int skip;

int main()
{
    cin.getline(s, 1001);
    for(int i = 0; i < strlen(s); i++){
        if(s[i] == ' ' && ok){
            strcpy(temp, s + i);
            strcpy(s + i, " \0");
            skip = strlen(s);
            strcpy(s + i + 2, s);
            cout << s;
            strcat(s, temp);
            i += skip + 1;
            ok = true;
        }
        else if(strchr(voc, s[i]) == 0) ok = false;
    }
    cout << s;
    return 0;
}
