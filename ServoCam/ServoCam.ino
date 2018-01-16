#include <Servo.h>

Servo s1, s2;
char buf;
uint8_t value;

void setup() {
    s1.attach(3); s1.write(90);
    s2.attach(5); s2.write(90);
    
    Serial.begin(9600);
}

void loop() {
    if (Serial.available() > 0) {
        buf = Serial.read();
        switch (buf) {
            case 'A':
                value = Serial.parseInt();
                value = value > 180 ? 180 : (value < 0 ? 0 : value);
                s1.write(value);
                break;
            case 'B':
                value = Serial.parseInt();
                value = value > 180 ? 180 : (value < 0 ? 0 : value);
                s2.write(value);
                break;
            case 'R':
                s1.write(90);
                s2.write(90);
                break;
        }
    }
}
