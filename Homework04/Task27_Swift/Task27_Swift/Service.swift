//
//  Service.swift
//  Task27_Swift
//
//  Created by Daniil Rassadin on 9/12/22.
//

import Foundation

func countOfNumbers(in number: Int) -> Int {
    var count = 1
    if number == 0 { return count }
    
    var mutableNumber = number
    count = 0
    if mutableNumber < 0 {
        mutableNumber = -mutableNumber
    }
    while mutableNumber > 0 {
        mutableNumber /= 10
        count += 1
    }
    return count
}
