#pragma once
#include "Monster.h"

class Digimon : public Monster
{
public:
	Digimon(string, int);
	~Digimon();
	virtual void Introduce();

protected:

};

