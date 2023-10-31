#include <iostream>
using namespace std;
int main() {
    int n;
    cin >> n;

    int sum = 0;
    int coupon = 0; // ������� ������� �� ���������� ����

    for (int i = 0; i < n; i++) {
        int cost;
        cin >> cost;

        // ���� � ���� ���� ����� �� ���������� ����, �� ��� ����������
        if (coupon > 0) {
            coupon--;
        }
        else {
            sum += cost;
            // ���� ��������� ����� ������ 100 ������, ���� �������� ����� �� ���������� ����
            if (cost > 100) {
                coupon++;
            }
        }
    }

    cout << sum << endl;
	return 0;
}