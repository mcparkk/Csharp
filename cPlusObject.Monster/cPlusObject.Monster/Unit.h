#pragma once
#include<iostream>
#include <string>
using namespace std;

class Unit
{
public:
	Unit (string , int );
	~Unit();

	void virtual Introduce();

protected:
	string _name;
	int _hp;
};


