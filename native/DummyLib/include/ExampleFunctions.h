
#ifndef EXAMPLEFUNCTIONS_H
#define EXAMPLEFUNCTIONS_H

#ifdef __cplusplus
extern "C" {
#endif
    __declspec(dllexport) float Q_rsqrt(float number);

    __declspec(dllexport) bool IsNegative(int number);

    __declspec(dllexport) void PrintMessage(char* msg);

    __declspec(dllexport) void PrintMessageW(wchar_t* msg);

    struct Point
    {
        double x;
        double y;
    };

    __declspec(dllexport) void PrintPoint(Point point);

#ifdef __cplusplus
}
#endif

#endif

