#include <iostream>
using namespace std;
/**
测试有关内存对齐的问题
windows中可以取到的值为1,2,4,8,16
linux 中的g++只能是1,2,4
*/
#pragma pack(1)
struct  A
{
	int a;
	char b;
	short c;
};
#pragma pack(pop)


#pragma pack(4)  
struct teacher  
{  
    char a;  //1  
    double c;//1+3+8=12  
    int b;//1+3+8+4=16  
};  
struct student  
{  
    char a; //1  
    double c;//1+3+8=12  
    int b;//1+3+8+4=16  
    char d;//16+1=17  
    teacher e; //把17填充到4的倍数：20，20+16=36，为4的倍数了，直接输出大小  
    //char f; //此时输出为40  
};  
#pragma pack(pop)  


void main(){
	cout<<sizeof(A)<<endl;
	cout<<sizeof(teacher)<<endl;
	cout<<sizeof(student)<<endl;
	getchar();

}