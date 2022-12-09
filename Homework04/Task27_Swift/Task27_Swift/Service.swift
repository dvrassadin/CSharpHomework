//
//  Service.swift
//  Task27_Swift
//
//  Created by Daniil Rassadin on 9/12/22.
//

import Foundation

func sumOfNumbers(in number: Int) -> Int {
    var sum = 0
    var mutableNumber = number
    if mutableNumber < 0 {
        mutableNumber = -mutableNumber
    }
    while mutableNumber > 0 {
        sum += mutableNumber % 10
        mutableNumber /= 10
    }
    return sum
}
