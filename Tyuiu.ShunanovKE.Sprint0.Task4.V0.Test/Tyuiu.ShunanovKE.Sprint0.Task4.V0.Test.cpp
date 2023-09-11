#include "pch.h"
#include "CppUnitTest.h"
#include "../Tyuiu.ShunanovKE.Sprint0.Task4.V0.Lib/Tyuiu.ShunanovKE.Sprint0.Task4.V0.Lib.cpp"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest3
{
	TEST_CLASS(UnitTest3)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{ //Init
			ISprint0Task4* ans = new Service2();
			int a = 25;
			int b = 8;
			int c = 4;
			int d = 9;
			int ans1;

		  //run
			ans1 = ans->Calculate(a, b, c, d);

		  //Valid
			Assert::AreEqual(7, ans1);
		}
	};
}
