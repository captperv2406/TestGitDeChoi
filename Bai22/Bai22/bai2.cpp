#pragma once

#include <iostream>
#include <string.h>
#include <string>

using namespace std;

class NhanVien {
protected:
	string masonhanvien;
	string hoten;
	int namsinh;
	string masothue;
public:
	NhanVien();
	NhanVien( string, string, int, string);
	NhanVien(const NhanVien &);
	~NhanVien();
	virtual string loaiNhanVien() = 0;
	virtual double tinhTienLuong() = 0;
	static void hienThiLuong(NhanVien *pnv[], int);
};

class NhanVienToanThoiGian : public NhanVien {
private:
	int bac, phucap, luongcoban;
public:
	NhanVienToanThoiGian();
	NhanVienToanThoiGian(string, string, int, string, int, int, int);
	NhanVienToanThoiGian(const NhanVienToanThoiGian &);
	~NhanVienToanThoiGian();
	
	string loaiNhanVien();
	double tinhTienLuong();
	friend ostream & operator << (ostream & os, NhanVienToanThoiGian);
};

class NhanVienBanThoiGian : public NhanVien {
private:
	int sogiolamviec, tiencongmoigio;
	double thue;
public:
	NhanVienBanThoiGian();
	NhanVienBanThoiGian(string, string, int, string, int, int);
	NhanVienBanThoiGian(const NhanVienBanThoiGian &);
	~NhanVienBanThoiGian();

	string loaiNhanVien();
	double tinhTienLuong();
	friend ostream & operator << (ostream & os, NhanVienBanThoiGian);
};

int main() {
	int n;
	int luongcoban, tiencongmoigio;
	string s[100];
	NhanVien *p[100];
	cin >> n;
	cin >> luongcoban >> tiencongmoigio;
	for (int i = 0; i < n; i++)
	{
		cin >> s[i];
		if (s[i] == "TTG")
		{
			string masonv, hoten;
			int namsinh;
			string masothue;
			int bac, phucap;
			cin.ignore();
			cin >> masonv >> hoten >> namsinh >> masothue >> bac >> phucap;
			if (masothue == "#")
			{
				masothue == "Khong co";
			};
			NhanVienToanThoiGian *a = new NhanVienToanThoiGian(masonv, hoten, namsinh, masothue, bac, phucap, luongcoban);
			p[i] = a;
		}
		if (s[i] == "BTG")
		{
			string masonv, hoten;
			int namsinh;
			string masothue;
			int sogiolamviec;
			cin.ignore();
			cin >> masonv >> hoten >> namsinh >> masothue >> sogiolamviec;
			if (masothue == "#")
			{
				masothue == "Khong co";
			};
			NhanVienBanThoiGian *a = new NhanVienBanThoiGian(masonv, hoten, namsinh, masothue, sogiolamviec, tiencongmoigio);
			p[i] = a;
		}
	}
	cout << endl << "Bang Tien Luong Cong Ty" << endl << endl;
	
	for (int i = 0; i < n; i++)
	{
		cout << (p[i]);
	}

	system("pause");
	return 0;
};

// nhan vien

NhanVien::NhanVien() {};
NhanVien::NhanVien(string code, string name, int birthday, string tax) {
	this->masonhanvien = code;
	this->hoten = name;
	this->namsinh = birthday;
	this->masothue = tax;
};
NhanVien::NhanVien(const NhanVien &a) {
	this->hoten = a.hoten;
	this->masonhanvien = a.masonhanvien;
	this->namsinh = a.namsinh;
	this->masothue = a.masothue;
};
NhanVien::~NhanVien() {};
void NhanVien::hienThiLuong(NhanVien *pnv[], int n) {
	for (int i = 0; i < n; i++)
	{
		cout << pnv[i];
	}
};


// nhan vien toan thoi gian

NhanVienToanThoiGian::NhanVienToanThoiGian() {};
NhanVienToanThoiGian::NhanVienToanThoiGian(string code, string name, int birthday, string tax, int level, int benefit, int salary) : NhanVien(code, name, birthday, tax) {
	this->bac = level;
	this->phucap = benefit;
	this->luongcoban = salary;
};
NhanVienToanThoiGian::NhanVienToanThoiGian(const NhanVienToanThoiGian &a) {
	this->masonhanvien = a.masonhanvien;
	this->hoten = a.hoten;
	this->namsinh = a.namsinh;
	this->masothue = a.masothue;
	this->bac = a.bac;
	this->phucap = a.phucap;
	this->luongcoban = a.luongcoban;
};
NhanVienToanThoiGian::~NhanVienToanThoiGian() {};

string NhanVienToanThoiGian::loaiNhanVien() {
	return "Toan thoi gian";
};
double NhanVienToanThoiGian::tinhTienLuong() {
	double luong;
	luong = this->bac * this->luongcoban + this->phucap;
	return luong;
};
ostream & operator << (ostream & os, NhanVienToanThoiGian a) {
	os << a.masonhanvien << ": " << a.hoten << endl;
	os << "Loai: " << a.loaiNhanVien() << endl;
	os << "Ma so thue:" << a.masothue << endl;
	os << "Nam sinh:" << a.namsinh << endl;
	os << "Bac: " << a.bac << endl;
	os << "Phu cap: " << a.phucap << endl;
	os << "Luong: " << a.bac << "*" << a.luongcoban << "+" << a.phucap << "=" << a.tinhTienLuong() << " (vnd)" << endl;
	return os;
};

// nhan vien ban thoi gian

NhanVienBanThoiGian::NhanVienBanThoiGian() {};
NhanVienBanThoiGian::NhanVienBanThoiGian(string code, string name, int birthday, string tax, int working, int earnmoney) : NhanVien(code, name, birthday, tax) {
	if (this->masothue == "#")
	{
		this->thue = 0.2;
	}
	else
	{
		this->thue = 0.1;
	}
	this->sogiolamviec = working;
	this->tiencongmoigio = earnmoney;
};
NhanVienBanThoiGian::NhanVienBanThoiGian(const NhanVienBanThoiGian &a) {
	this->masonhanvien = a.masonhanvien;
	this->hoten = a.hoten;
	this->namsinh = a.namsinh;
	this->masothue = a.masothue;
	this->thue = a.thue;
	this->sogiolamviec = a.sogiolamviec;
	this->tiencongmoigio = a.tiencongmoigio;
};
NhanVienBanThoiGian::~NhanVienBanThoiGian() {};
string NhanVienBanThoiGian::loaiNhanVien() {
	return "Ban thoi gian";
};
double NhanVienBanThoiGian::tinhTienLuong() {
	if (this->masothue == "#")
	{
		return this->sogiolamviec*1.0 * this->tiencongmoigio - this->thue * this->sogiolamviec * this->tiencongmoigio;
	}
	else
	{
		return this->sogiolamviec*1.0 * this->tiencongmoigio - this->thue * this->sogiolamviec * this->tiencongmoigio;
	}
};
ostream & operator << (ostream & os, NhanVienBanThoiGian a) {
	os << a.masonhanvien << ": " << a.hoten << endl;
	os << "Loai: " << a.loaiNhanVien() << endl;
	os << "Ma so thue:" << a.masothue << endl;
	os << "Nam sinh:" << a.namsinh << endl;
	os << "Thoi gian: " << a.sogiolamviec << endl;
	os << "Luong: " << a.sogiolamviec << "*" << a.tiencongmoigio << "-" << a.sogiolamviec << "*" << a.tiencongmoigio << "*" << a.thue * 100 << "%" << "=" << a.tinhTienLuong() << " (vnd)" << endl;
	return os;
};