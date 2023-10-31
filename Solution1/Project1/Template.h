#pragma once
#include "iostream"
using namespace std;
template <typename First, typename Second>
class Pair
{
	First first;
	Second second;

public:
	//Pair() : first{ }, second{ } {}
	Pair(First first, Second second) : first{first}, second{second} {};


	First getfirst() const { return first };
	First getsecond() const { return second };


	void setfirst(const First& first) {
		this->first = first;
	}
	void setsecond(const First& second) {
		this->second = second;
	}

	

};

template<typename First,typename Second>
void Pair <First, Second> ::setfirst(const First& first) {
	this 
}



