static void f1(S s) {
    s.i += 1;
}
static String f2() {
    S s;
    s.i = 42;
    f1(s);
    return s.i.ToString();
}

struct S {
    public int i;
}
