#include <stdio.h>
int main()
{
	int i, n;
	int corte = 0;
	int pedaco = 0;
	scanf("%d", &n);
	for(i = 0; i<n;i++)
	{
		scanf("%d", &corte);
		pedaco += corte - 1;
	}
	printf("%d",pedaco);
	return 0;

}