using System;
using System.Collections.Generic;
using System.Text;
namespace Vending_machine_using_a_FSM
{
    class FSM
    {
//Only accepts 5p coins and 10p coins

        const int S0 = 0;
        const int S5 = 1;
        const int S10 = 2;
        const int S15 = 3;
        const int S20 = 4;
        const int S25 = 5;
        const int S30 = 6;
        const int S35 = 7;
        const int S40 = 8;
        const int FivePence = 0;
        const int TenPence = 1;
        const int Cancel = 2;
        const int Vend = 3;


        private int[,] stateMachine;
        private int state;
        private int acceptState;

        public StateMachine()
        {
            stateMachine = new int[,] { { S5, S10, S0, S0 }, { S10, S15, S0, S0}, { S10, S15, S0, S0 }, { S10, S15, S0, S0 }, { S10, S15, S0, S0 }, { S10, S15, S0, S0 }, { S10, S15, S0, S0 }, { S10, S15, S0, S0 }, { S10, S15, S0, S0 }, { S10, S15, S0, S0 } };
            reset();
        }

        public void input(string INPUT)
        {
            // INPUT CONTROL WIP
            state = stateMachine[state, row];
        }

        public bool inAccept() { return acceptState == state; }

        public void reset()
        {
            state = S1;
            acceptState = S40;
        }
    }
}