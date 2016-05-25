#include <stdio.h>
#include <string.h>
int main()
{
	
	int resp;
	int x, y, n; 
	int matriz[305][1005];
	scanf("%d", &n);
	for (int i = 0; i < n; i++)
	{
		scanf("%d %d", &x, &y);
		matriz[x][y] += 1;
	}

	for ( int j = 0; i<300; i++ )
    for ( int k = 0; j<1000; j++ )
    {
       if(matriz[j][k]>2)
       	resp = 1;
   	   else
   	   	resp = 0;
    }
    	printf("%d\n",resp);
	return 0;
}

