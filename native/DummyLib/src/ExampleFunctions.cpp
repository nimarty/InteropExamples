#include "ExampleFunctions.h"

#include <codecvt>
#include <iostream>

std::string utf16WStrToUtf8Str(const std::wstring& wStr)
{
    using convert_type = std::codecvt_utf8_utf16<wchar_t>;
    std::wstring_convert<convert_type, wchar_t> converter;
    return converter.to_bytes(wStr);
}

#ifdef __cplusplus
extern "C" {
#endif

float Q_rsqrt(float number)
{
    long i;
    float x2, y;
    const float threehalfs = 1.5F;

    x2 = number * 0.5F;
    y = number;
    i = *(long*)&y;                             // evil floating point bit level hacking
    i = 0x5f3759df - (i >> 1);                  // what the fuck? 
    y = *(float*)&i;
    y = y * (threehalfs - (x2 * y * y));        // 1st iteration
//	y  = y * ( threehalfs - ( x2 * y * y ) );   // 2nd iteration, this can be removed

    return y;
}

bool IsNegative(int number)
{
    if (number < 0) {
        return true;
    }
    return false;
}

void PrintMessage(char* msg)
{
    std::string msgStr(msg);
    std::cout << msgStr << std::endl;
}

void PrintMessageW(wchar_t* msg)
{
    std::wstring msgWStr(msg);
    std::string msgStr = utf16WStrToUtf8Str(msgWStr);
    std::cout << msgStr << std::endl;
}

void PrintPoint(Point point)
{
    std::cout << "X: " << point.x << " Y: " << point.y << std::endl;
}

#ifdef __cplusplus
}
#endif
