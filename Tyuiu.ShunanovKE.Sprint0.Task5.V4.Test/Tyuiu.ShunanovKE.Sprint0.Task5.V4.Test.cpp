#include "pch.h"
#include "CppUnitTest.h"
#include "../Tyuiu.ShunanovKE.Sprint0.Task5.V4.Lib/Tyuiu.ShunanovKE.Sprint0.Task5.V4.Lib.cpp"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest4
{
	TEST_CLASS(UnitTest4)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			//Init
			ISprint0Task5* d = new Service();
			float a = 67;
			float b = 8.5;
			float c = 6.5;
			float ans;

			//Run
			ans = d->Zadacha(a,b,c);

			//Valid
			Assert::AreEqual(ans, ans);

		}
	};
}
