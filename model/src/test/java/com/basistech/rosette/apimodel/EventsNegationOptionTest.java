/*
 * Copyright 2023 Basis Technology Corp.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package com.basistech.rosette.apimodel;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertNull;

class EventsNegationOptionTest {

    @Test
    void forValueSuccess() {
        assertEquals(EventsNegationOption.IGNORE, EventsNegationOption.forValue("ignore"));
        assertEquals(EventsNegationOption.BOTH, EventsNegationOption.forValue("BOTH"));
        assertEquals(EventsNegationOption.ONLY_POSITIVE, EventsNegationOption.forValue("Only Positive"));
        assertEquals(EventsNegationOption.ONLY_NEGATIVE, EventsNegationOption.forValue("OnLy NeGaTiVe"));
    }

    @Test
    void forValueFailure() {
        assertNull(EventsNegationOption.forValue("dummy"));
    }
}