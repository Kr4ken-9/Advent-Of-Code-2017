#include "Days.h"

int Captcha(const std::string Input)
{
    int Output = 0;
    int Length = Input.length();
    int ArrayLength = Length - 1;

    for(int i = 0; i < Length; i++)
    {
        if(i == ArrayLength)
        {
            if (Input[i] == Input[0])
                Output += stoi(string(1, Input[i]));

            break;
        }

        if(Input[i] == Input[i + 1])
            Output += stoi(string(1, Input[i]));
    }

    return Output;
}
