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
	cout<<"���ù��캯��"<<endl;
}

Box::~Box()
{
 cout<<"������������"<<endl;
}

void main1(){

	Box * myboxArray=new Box[4];
	delete[]myboxArray;//delete the array

	getchar();

}


