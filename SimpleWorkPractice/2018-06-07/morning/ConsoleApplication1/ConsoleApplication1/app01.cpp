#include <iostream>

using namespace std;


class Box
{
public:
	Box();
	~Box();



};

Box::Box()
{
	cout<<"调用构造函数"<<endl;
}

Box::~Box()
{
 cout<<"调用析构函数"<<endl;
}

void main1(){

	Box * myboxArray=new Box[4];
	delete[]myboxArray;//delete the array

	getchar();

}


