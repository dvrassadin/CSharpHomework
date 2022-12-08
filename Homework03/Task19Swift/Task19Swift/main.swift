//
//  main.swift
//  Task19Swift
//
//  Created by Daniil Rassadin on 8/12/22.
//

import Foundation

print("Введите число: ", terminator: "")
var number: Int?

if let input = readLine() {
    if let int = Int(input) {
        number = int
    }
}

if let number {
    if isPalindrome(number) {
        print("Это палиндром.")
    } else {
        print("Это не палиндром.")
    }
} else {
    print("Число не получено.")
}





