#include <iostream>
using namespace std;
/**
�����й��ڴ���������
windows�п���ȡ����ֵΪ1,2,4,8,16
linux �е�g++ֻ����1,2,4
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
    teacher e; //��17��䵽4�ı�����20��20+16=36��Ϊ4�ı����ˣ�ֱ�������С  
    //char f; //��ʱ���Ϊ40  
};  
#pragma pack(pop)  


void main(){
	cout<<sizeof(A)<<endl;
	cout<<sizeof(teacher)<<endl;
	cout<<sizeof(student)<<endl;
	getchar();

}