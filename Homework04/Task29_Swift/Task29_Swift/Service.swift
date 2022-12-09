//
//  Service.swift
//  Task29_Swift
//
//  Created by Daniil Rassadin on 9/12/22.
//

import Foundation

func fillArray(_ array: inout [Int], with amount: Int) {
    for _ in 1...amount {
        array.append(Int.random(in: -1000...1000))
    }
}

func printArray(_ array: [Int]) {
    for element in array {
        print(element, terminator: ", ")
    }
}
