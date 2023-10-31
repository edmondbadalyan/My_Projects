#include <iostream>

class Fraction {

private:
	int numerator;
	int denominator;
public:
	Fraction() {
		numerator = 0;
		denominator = 0;
	}
         
	Fraction(int numer,int denom) {
		numerator = numer;
		denominator = denom;

	}

	void setNumerator(int numer) {
		numerator = numer;
	}
	int getNumerator()
	{
		return numerator;
	}
	void setDenominator(int denom) {
		denominator = denom;
	}
	int getDenominator() {
		return denominator;
	}


	Fraction add(const Fraction& other) {
		int resultnum = 
		int resultdenom =
	}

};


int main() {

	return 0;
}