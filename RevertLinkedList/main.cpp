#include <iostream>
using namespace std;

struct El
{
    El()
    {
        i = 0;
        el = NULL;
    }

    int i;
    El* el;
};

int main(int argc, char *argv[])
{
    int elCount = 10;
    El* first = new El();
    first->i = 0;
    El* prev = first;
    for (int i = 1; i < elCount; ++i)
    {
        El* el = new El();
        el->i = i;
        prev->el = el;        
        prev = el;
    }

    El* check = first;
    while (check != NULL)
    {
        cout << check->i;
        check = check->el;
    }
	cout << endl;
	char tmp;
	cin >> tmp;

    //revert
    El* current = first;
    prev = NULL;
    while (current != NULL)
    {
        El* next = current->el;
        current->el = prev;
        prev = current;
        current = next;
    }
    check = prev;
    int v1 = prev->i;
    int v2 = prev->el->i;
    while (check != NULL)
    {
		cout << check->i;
        check = check->el;
    }
	cout << endl;
	cin >> tmp;
	return 0;
}
