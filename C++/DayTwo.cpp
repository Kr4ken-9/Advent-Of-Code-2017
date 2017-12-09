#include "Days.h"

// https://stackoverflow.com/questions/236129/the-most-elegant-way-to-iterate-the-words-of-a-string
template<typename Out>
void split(const string &s, char delim, Out result) {
    stringstream ss(s);
    string item;
    while (getline(ss, item, delim)) {
        *(result++) = item;
    }
}

vector<string> split(const string &s, char delim) {
    vector<string> elements;
    split(s, delim, back_inserter(elements));
    return elements;
}

int Checksum(const vector<string> rows[])
{
    int Output = 0;

    for(int i = 0; i < (*rows).size(); i++)
    {
        const string row = (*rows)[i];

        const vector<string> ints = split(row, ' ');

        int Lowest = 1337420;

        int Highest = 0;

        for(int o = 0; o < ints.size(); o++)
        {
            const int integer = stoi(ints[o]);

            if(integer > Highest)
                Highest = integer;

            if(integer < Lowest)
                Lowest = integer;
        }

        Output += Highest - Lowest;
    }

    return Output;
}