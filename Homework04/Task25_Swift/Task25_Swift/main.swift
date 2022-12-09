//
//  main.swift
//  Task25_Swift
//
//  Created by Daniil Rassadin on 9/12/22.
//

import Foundation

var number: Int?
var pow: Int?
let convertError = "Введено некорректное число."

print("Введите целое число: ", terminator: "")
if let inpout = readLine() {
    if let int = Int(inpout) {
        number = int
        print("Введите натуральную степень числа: ", terminator: "")
        if let inpout = readLine() {
            if let int = Int(inpout) {
                pow = int
            } else { print(convertError) }
        } else { print(convertError) }
    } else { print(convertError) }
} else { print(convertError) }

if let number, let pow {
    if let result = Exponentiation(number: number, in: pow) {
        print("\(number) в степени \(pow) равно \(result).")
    } else {
        print("Введена ненатуральная степень.")
    }
}
