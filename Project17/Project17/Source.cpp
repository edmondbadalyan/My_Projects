#include <iostream>
using namespace std;
int main() {
    int n;
    cin >> n;

    int sum = 0;
    int coupon = 0; // счетчик купонов на бесплатный обед

    for (int i = 0; i < n; i++) {
        int cost;
        cin >> cost;

        // если у Дани есть купон на бесплатный обед, он его использует
        if (coupon > 0) {
            coupon--;
        }
        else {
            sum += cost;
            // если стоимость обеда больше 100 рублей, Даня получает купон на бесплатный обед
            if (cost > 100) {
                coupon++;
            }
        }
    }

    cout << sum << endl;
	return 0;
}