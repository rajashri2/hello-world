static void f1(ref String s1, out String s2) {
    s1 += "0";
    s2 = "45";
}
static String f2() {
    String s1 = "42", s2;
    f1(ref s1, out s2);
    return s1 + s2;
}

class S {
    public int I;
}
