static void f1(out String s1, ref String s2) {
    s1 += "0";
    s2 += "0";
}
static String f2() {
    String s1 = "42", s2 = "43";
    f1(out s1, ref s2);
    return s1 + s2;
}

class S {
    public int I;
}
