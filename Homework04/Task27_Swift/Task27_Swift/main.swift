//
//  main.swift
//  Task27_Swift
//
//  Created by Daniil Rassadin on 9/12/22.
//

import Foundation

var number: Int?
let convertError = "Введено некорректное число."

print("Введите число: ", terminator: "")
if let input = readLine() {
    if let int = Int(input) {
        print("Сумма цифр: \(sumOfNumbers(in: int)).")
    } else { print(convertError) }
} else { print(convertError) }

