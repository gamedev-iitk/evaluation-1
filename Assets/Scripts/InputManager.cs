using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    bool canInput = false;

    char[] letters = { 'A', 'a', 'B', 'b', 'C', 'c' ,'D', 'd','E', 'e',
                       'F', 'f', 'G', 'g', 'H', 'h', 'I', 'i', 'J', 'j',
                       'K', 'k', 'L', 'l', 'M', 'm', 'N', 'n', 'O', 'o',
                       'P', 'p', 'Q', 'q', 'R', 'r', 'S', 's', 'T', 't',
                       'U', 'u', 'V', 'v', 'W', 'w', 'X', 'x', 'Y', 'y',
                       'Z', 'z'};

    KeyCode GetKey(char c)
    {
        switch (c)
        {
            case 'A':
            case 'a':
                return KeyCode.A;
            case 'B':
            case 'b':
                return KeyCode.B;
            case 'C':
            case 'c':
                return KeyCode.C;
            case 'D':
            case 'd':
                return KeyCode.D;
            case 'E':
            case 'e':
                return KeyCode.E;
            case 'F':
            case 'f':
                return KeyCode.F;
            case 'G':
            case 'g':
                return KeyCode.G;
            case 'H':
            case 'h':
                return KeyCode.H;
            case 'I':
            case 'i':
                return KeyCode.I;
            case 'J':
            case 'j':
                return KeyCode.J;
            case 'K':
            case 'k':
                return KeyCode.K;
            case 'L':
            case 'l':
                return KeyCode.L;
            case 'M':
            case 'm':
                return KeyCode.M;
            case 'N':
            case 'n':
                return KeyCode.N;
            case 'O':
            case 'o':
                return KeyCode.O;
            case 'P':
            case 'p':
                return KeyCode.P;
            case 'Q':
            case 'q':
                return KeyCode.Q;
            case 'R':
            case 'r':
                return KeyCode.R;
            case 'S':
            case 's':
                return KeyCode.S;
            case 'T':
            case 't':
                return KeyCode.T;
            case 'U':
            case 'u':
                return KeyCode.U;
            case 'V':
            case 'v':
                return KeyCode.V;
            case 'W':
            case 'w':
                return KeyCode.W;
            case 'X':
            case 'x':
                return KeyCode.X;
            case 'Y':
            case 'y':
                return KeyCode.Y;
            case 'Z':
            case 'z':
                return KeyCode.Z;
            default:
                return KeyCode.None;
        }
    }

    public char CheckInput()
    {
        if (canInput)
        {
            for (int i = 1; i <= 52; i++)
            {
                if (Input.GetKeyUp(GetKey(letters[i - 1])))
                {
                    return ((i - 1) % 2 == 0) ? (letters[i - 1]) : (letters[i - 2]);
                }
            }
        }
        return '0';
    }

    void Update()
    {
        if (canInput)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                GetComponent<QuizManager>().NewRow();
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                GetComponent<QuizManager>().Delete();
            }
        }
    }

    public void SetStatus(bool status)
    {
        canInput = status;
    }
}
