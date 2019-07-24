#pragma once
#include "Unit.h"

class Person : public Unit
{
public:
	Person(string, int);
	~Person();
	virtual void Introduce();

protected:

	

};

