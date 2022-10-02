#include <stdexcept>
#include <iostream>

void f();
void q();

int main()
{
	f();
	return 0;
}

void f()
{
	try {
		std::cout << "start" << std::endl;
		int* a = new int();
		std::cout << "create ptr" << std::endl;
		q();
		std::cout << "continue" << std::endl;
		delete a;
		std::cout << "ptr delete" << std::endl;
	}
	catch (...)
	{
		std::cout << "exception catch" << std::endl;
	}
	
}

void q()
{
	std::cout << "exception throw" << std::endl;
	throw std::invalid_argument("bad");
}