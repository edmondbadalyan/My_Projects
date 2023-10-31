#include <iostream>
using namespace std;
template<typename T>
class Array {
private:
	T* data;
	int size;
	int capacity;
public:
	int Getsize() const {
		return size;
	}
	void Setsize(int Newsize,int grow = 1) {
		if (Newsize <= capacity) {
			size = Newsize;
		}
		else {
			int newCapacity = capacity + ((Newsize - capacity) / grow + 1) * grow;;
			T* Newdata = new T[newCapacity];
			for (int i = 0; i < size; ++i) {
				Newdata[i] = data[i];
			}
			delete[] data;
			data = Newdata;
			size = Newsize;
			capacity = newCapacity;
		}
	}
	int GetUpperbound()const {
		return size - 1;
	}
	bool isEmpty()const {
		return size == 0;
	}
	void freeExtra() {
		if (size > capacity) {
			T* Newdata = new T[size];
			for (int i = 0; i < size; ++i) {
				Newdata[i] = data[i];
			}
			delete[] data;
			size = Newdata;
			capacity = size;
		}
	}
	void Removeall() {
		delete[] data;
		data = nullptr;
		size = 0;
		capacity = 0;
	}
	const T& getAt(int index) const {
		if (index >= 0 && index < size) {
			return data[index];
		}
	}
	void setAt(int index,int value){
		if (index >= 0 && index < size) {
			data[index] = value;
		}	
	}
	const T& operator [] (int index)const {
		return getAt(index);
	}
	void Add(const T& value) {
		Setsize(size + 1);
		data[size - 1] = value;

	}
	void Append(const Array<T>& other) {
		int Newsize = size + other.size;
		for (int i = 0; i < other.size;++i) {
			data[size - other.size + i] = other.size[i];
		}
	}
	T* Getdata() const {
		return data;
	}
	void InsertAt(int index,const T& value) {
		if (index >= 0 && index <= size) {
			Setsize(size + 1);
		}
		for (int i = size - 1; i > index;--i) {
			data[i] = data[i - 1];
		}
		data[index] = value;
		
			return 0;
		
	}
	void RemoveAt(int index) {
		if (index >= 0 && index < size) {
			Setsize(size - 1);

			for (int i = index; i < size - 1; ++i) {
				data[i] = data[i + 1];
			}

			return 0;
		}
	}

	

};


	int main() {

		Array<int> arr;

		arr.Setsize(5, 5);
		for (int i = 0; i < arr.Getsize(); ++i) {
			arr.setAt(i, i + 1);
		}
		cout << "array size:" << arr.Getsize() << endl;
		cout << "array elements:";
		for (int i = 0; i < arr.Getsize(); i++) {
			std::cout << arr.getAt(i) << " ";
		}
		std::cout << std::endl;




		return 0;
	}