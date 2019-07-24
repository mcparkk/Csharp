#pragma once

#include "Unit.h"


class Monster : public Unit
{
public:
	Monster(string, int, int);
	~Monster();
	virtual void Introduce();

protected:
	int offencePower;

};


