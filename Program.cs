using System;
using System.Diagnostics;
using System.IO;

class Smaker {
    public void Unity() {
        Process.Start("unity.ps1");
    }

}
class Program {
    static void Main(string[] args) {
        Smaker smaker = new Smaker();
        smaker.Unity();
    }
}