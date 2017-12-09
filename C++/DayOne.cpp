#include "Days.h"

int Captcha(const std::string Input)
{
    int Output = 0;

    for(int i = 0; i < Input.length(); i++)
    {
        if(i == Input.length() - 1)
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

int CaptchaPtTwo(const std::string Input)
{
    int Output = 0;
    const int Offset = Input.length() / 2;

    for(int i = 0; i < Input.length(); i++)
    {
        int Index = i + Offset;

        if(Index >= Input.length())
            Index = Index - Input.length();

        if(Input[i] == Input[Index])
            Output += stoi(string(1, Input[i]));
    }

    return Output;
}
