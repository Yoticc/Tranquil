﻿namespace Tranquil.Schema;

public record DotaPacket
{
#pragma warning disable CS8625
    public static Type[] PacketTypes = 
    [
        /* 0   */ typeof(CNETMsg_NOP),
        /* 1   */ null,
        /* 2   */ null,
        /* 3   */ typeof(CNETMsg_SplitScreenUser),
        /* 4   */ typeof(CNETMsg_Tick),
        /* 5   */ typeof(CNETMsg_StringCmd),
        /* 6   */ typeof(CNETMsg_SetConVar),
        /* 7   */ typeof(CNETMsg_SignonState),
        /* 8   */ typeof(CNETMsg_SpawnGroup_Load),
        /* 9   */ typeof(CNETMsg_SpawnGroup_ManifestUpdate),
        /* 10  */ null,
        /* 11  */ typeof(CNETMsg_SpawnGroup_SetCreationTick),
        /* 12  */ typeof(CNETMsg_SpawnGroup_Unload),
        /* 13  */ typeof(CNETMsg_SpawnGroup_LoadCompleted),
        /* 14  */ null,
        /* 15  */ typeof(CNETMsg_DebugOverlay),
        /* 16  */ null,
        /* 17  */ null,
        /* 18  */ null,
        /* 19  */ null,
        /* 20  */ null,
        /* 21  */ null,
        /* 22  */ null,
        /* 23  */ null,
        /* 24  */ null,
        /* 25  */ null,
        /* 26  */ null,
        /* 27  */ null,
        /* 28  */ null,
        /* 29  */ null,
        /* 30  */ null,
        /* 31  */ null,
        /* 32  */ null,
        /* 33  */ null,
        /* 34  */ null,
        /* 35  */ null,
        /* 36  */ null,
        /* 37  */ null,
        /* 38  */ null,
        /* 39  */ null,
        /* 40  */ typeof(CSVCMsg_ServerInfo),
        /* 41  */ typeof(CSVCMsg_FlattenedSerializer),
        /* 42  */ typeof(CSVCMsg_ClassInfo),
        /* 43  */ typeof(CSVCMsg_SetPause),
        /* 44  */ typeof(CSVCMsg_CreateStringTable),
        /* 45  */ typeof(CSVCMsg_UpdateStringTable),
        /* 46  */ typeof(CSVCMsg_VoiceInit),
        /* 47  */ typeof(CSVCMsg_VoiceData),
        /* 48  */ typeof(CSVCMsg_Print),
        /* 49  */ typeof(CSVCMsg_Sounds),
        /* 50  */ typeof(CSVCMsg_SetView),
        /* 51  */ typeof(CSVCMsg_ClearAllStringTables),
        /* 52  */ typeof(CSVCMsg_CmdKeyValues),
        /* 53  */ typeof(CSVCMsg_BSPDecal),
        /* 54  */ typeof(CSVCMsg_SplitScreen),
        /* 55  */ typeof(CSVCMsg_PacketEntities),
        /* 56  */ typeof(CSVCMsg_Prefetch),
        /* 57  */ typeof(CSVCMsg_Menu),
        /* 58  */ typeof(CSVCMsg_GetCvarValue),
        /* 59  */ typeof(CSVCMsg_StopSound),
        /* 60  */ typeof(CSVCMsg_PeerList),
        /* 61  */ typeof(CSVCMsg_PacketReliable),
        /* 62  */ typeof(CSVCMsg_HLTVStatus),
        /* 63  */ typeof(CSVCMsg_ServerSteamID),
        /* 64  */ null,
        /* 65  */ null,
        /* 66  */ null,
        /* 67  */ null,
        /* 68  */ null,
        /* 69  */ null,
        /* 70  */ typeof(CSVCMsg_FullFrameSplit),
        /* 71  */ typeof(CSVCMsg_RconServerDetails),
        /* 72  */ typeof(CSVCMsg_UserMessage),
        /* 73  */ null,
        /* 74  */ typeof(CSVCMsg_Broadcast_Command),
        /* 75  */ typeof(CSVCMsg_HltvFixupOperatorStatus),
        /* 76  */ null,
        /* 77  */ null,
        /* 78  */ null,
        /* 79  */ null,
        /* 80  */ null,
        /* 81  */ null,
        /* 82  */ null,
        /* 83  */ null,
        /* 84  */ null,
        /* 85  */ null,
        /* 86  */ null,
        /* 87  */ null,
        /* 88  */ null,
        /* 89  */ null,
        /* 90  */ null,
        /* 91  */ null,
        /* 92  */ null,
        /* 93  */ null,
        /* 94  */ null,
        /* 95  */ null,
        /* 96  */ null,
        /* 97  */ null,
        /* 98  */ null,
        /* 99  */ null,
        /* 100 */ null,
        /* 101 */ typeof(CUserMessageAchievementEvent),
        /* 102 */ typeof(CUserMessageCloseCaption),
        /* 103 */ typeof(CUserMessageCloseCaptionDirect),
        /* 104 */ typeof(CUserMessageCurrentTimescale),
        /* 105 */ typeof(CUserMessageDesiredTimescale),
        /* 106 */ typeof(CUserMessageFade),
        /* 107 */ typeof(CUserMessageGameTitle),
        /* 108 */ null,
        /* 109 */ null,
        /* 110 */ typeof(CUserMessageHudMsg),
        /* 111 */ typeof(CUserMessageHudText),
        /* 112 */ null,
        /* 113 */ typeof(CUserMessageColoredText),
        /* 114 */ typeof(CUserMessageRequestState),
        /* 115 */ typeof(CUserMessageResetHUD),
        /* 116 */ typeof(CUserMessageRumble),
        /* 117 */ typeof(CUserMessageSayText),
        /* 118 */ typeof(CUserMessageSayText2),
        /* 119 */ typeof(CUserMessageSayTextChannel),
        /* 120 */ typeof(CUserMessageShake),
        /* 121 */ typeof(CUserMessageShakeDir),
        /* 122 */ typeof(CUserMessageWaterShake),
        /* 123 */ null,
        /* 124 */ typeof(CUserMessageTextMsg),
        /* 125 */ typeof(CUserMessageScreenTilt),
        /* 126 */ null,
        /* 127 */ null,
        /* 128 */ typeof(CUserMessageVoiceMask),
        /* 129 */ null,
        /* 130 */ typeof(CUserMessageSendAudio),
        /* 131 */ typeof(CUserMessageItemPickup),
        /* 132 */ typeof(CUserMessageAmmoDenied),
        /* 133 */ null,
        /* 134 */ typeof(CUserMessageShowMenu),
        /* 135 */ typeof(CUserMessageCreditsMsg),
        /* 136 */ typeof(CEntityMessagePlayJingle),
        /* 137 */ typeof(CEntityMessageScreenOverlay),
        /* 138 */ typeof(CEntityMessageRemoveAllDecals),
        /* 139 */ typeof(CEntityMessagePropagateForce),
        /* 140 */ typeof(CEntityMessageDoSpark),
        /* 141 */ typeof(CEntityMessageFixAngle),
        /* 142 */ typeof(CUserMessageCloseCaptionPlaceholder),
        /* 143 */ typeof(CUserMessageCameraTransition),
        /* 144 */ typeof(CUserMessageAudioParameter),
        /* 145 */ null,
        /* 146 */ null,
        /* 147 */ null,
        /* 148 */ null,
        /* 149 */ null,
        /* 150 */ typeof(CUserMessageHapticsManagerPulse),
        /* 151 */ typeof(CUserMessageHapticsManagerEffect),
        /* 152 */ null,
        /* 153 */ typeof(CUserMessageUpdateCssClasses),
        /* 154 */ typeof(CUserMessageServerFrameTime),
        /* 155 */ typeof(CUserMessageLagCompensationError),
        /* 156 */ typeof(CUserMessageRequestDllStatus),
        /* 157 */ typeof(CUserMessageRequestUtilAction),
        /* 158 */ null,
        /* 159 */ null,
        /* 160 */ typeof(CUserMessageRequestInventory),
        /* 161 */ null,
        /* 162 */ typeof(CUserMessageRequestDiagnostic),
        /* 163 */ null,
        /* 164 */ null,
        /* 165 */ null,
        /* 166 */ null,
        /* 167 */ null,
        /* 168 */ null,
        /* 169 */ null,
        /* 170 */ null,
        /* 171 */ null,
        /* 172 */ null,
        /* 173 */ null,
        /* 174 */ null,
        /* 175 */ null,
        /* 176 */ null,
        /* 177 */ null,
        /* 178 */ null,
        /* 179 */ null,
        /* 180 */ null,
        /* 181 */ null,
        /* 182 */ null,
        /* 183 */ null,
        /* 184 */ null,
        /* 185 */ null,
        /* 186 */ null,
        /* 187 */ null,
        /* 188 */ null,
        /* 189 */ null,
        /* 190 */ null,
        /* 191 */ null,
        /* 192 */ null,
        /* 193 */ null,
        /* 194 */ null,
        /* 195 */ null,
        /* 196 */ null,
        /* 197 */ null,
        /* 198 */ null,
        /* 199 */ null,
        /* 200 */ typeof(CMsgVDebugGameSessionIDEvent),
        /* 201 */ typeof(CMsgPlaceDecalEvent),
        /* 202 */ typeof(CMsgClearWorldDecalsEvent),
        /* 203 */ typeof(CMsgClearEntityDecalsEvent),
        /* 204 */ typeof(CMsgClearDecalsForSkeletonInstanceEvent),
        /* 205 */ typeof(CMsgSource1LegacyGameEventList),
        /* 206 */ typeof(CMsgSource1LegacyListenEvents),
        /* 207 */ typeof(CMsgSource1LegacyGameEvent),
        /* 208 */ typeof(CMsgSosStartSoundEvent),
        /* 209 */ typeof(CMsgSosStopSoundEvent),
        /* 210 */ typeof(CMsgSosSetSoundEventParams),
        /* 211 */ typeof(CMsgSosSetLibraryStackFields),
        /* 212 */ typeof(CMsgSosStopSoundEventHash),
        /* 213 */ null,
        /* 214 */ null,
        /* 215 */ null,
        /* 216 */ null,
        /* 217 */ null,
        /* 218 */ null,
        /* 219 */ null,
        /* 220 */ null,
        /* 221 */ null,
        /* 222 */ null,
        /* 223 */ null,
        /* 224 */ null,
        /* 225 */ null,
        /* 226 */ null,
        /* 227 */ null,
        /* 228 */ null,
        /* 229 */ null,
        /* 230 */ null,
        /* 231 */ null,
        /* 232 */ null,
        /* 233 */ null,
        /* 234 */ null,
        /* 235 */ null,
        /* 236 */ null,
        /* 237 */ null,
        /* 238 */ null,
        /* 239 */ null,
        /* 240 */ null,
        /* 241 */ null,
        /* 242 */ null,
        /* 243 */ null,
        /* 244 */ null,
        /* 245 */ null,
        /* 246 */ null,
        /* 247 */ null,
        /* 248 */ null,
        /* 249 */ null,
        /* 250 */ null,
        /* 251 */ null,
        /* 252 */ null,
        /* 253 */ null,
        /* 254 */ null,
        /* 255 */ null,
        /* 256 */ null,
        /* 257 */ null,
        /* 258 */ null,
        /* 259 */ null,
        /* 260 */ null,
        /* 261 */ null,
        /* 262 */ null,
        /* 263 */ null,
        /* 264 */ null,
        /* 265 */ null,
        /* 266 */ null,
        /* 267 */ null,
        /* 268 */ null,
        /* 269 */ null,
        /* 270 */ null,
        /* 271 */ null,
        /* 272 */ null,
        /* 273 */ null,
        /* 274 */ null,
        /* 275 */ null,
        /* 276 */ null,
        /* 277 */ null,
        /* 278 */ null,
        /* 279 */ null,
        /* 280 */ null,
        /* 281 */ null,
        /* 282 */ null,
        /* 283 */ null,
        /* 284 */ null,
        /* 285 */ null,
        /* 286 */ null,
        /* 287 */ null,
        /* 288 */ null,
        /* 289 */ null,
        /* 290 */ null,
        /* 291 */ null,
        /* 292 */ null,
        /* 293 */ null,
        /* 294 */ null,
        /* 295 */ null,
        /* 296 */ null,
        /* 297 */ null,
        /* 298 */ null,
        /* 299 */ null,
        /* 300 */ null,
        /* 301 */ null,
        /* 302 */ null,
        /* 303 */ null,
        /* 304 */ null,
        /* 305 */ null,
        /* 306 */ null,
        /* 307 */ null,
        /* 308 */ null,
        /* 309 */ null,
        /* 310 */ null,
        /* 311 */ null,
        /* 312 */ null,
        /* 313 */ null,
        /* 314 */ null,
        /* 315 */ null,
        /* 316 */ null,
        /* 317 */ null,
        /* 318 */ null,
        /* 319 */ null,
        /* 320 */ null,
        /* 321 */ null,
        /* 322 */ null,
        /* 323 */ null,
        /* 324 */ null,
        /* 325 */ null,
        /* 326 */ null,
        /* 327 */ null,
        /* 328 */ null,
        /* 329 */ null,
        /* 330 */ null,
        /* 331 */ null,
        /* 332 */ null,
        /* 333 */ null,
        /* 334 */ null,
        /* 335 */ null,
        /* 336 */ null,
        /* 337 */ null,
        /* 338 */ null,
        /* 339 */ null,
        /* 340 */ null,
        /* 341 */ null,
        /* 342 */ null,
        /* 343 */ null,
        /* 344 */ null,
        /* 345 */ null,
        /* 346 */ null,
        /* 347 */ null,
        /* 348 */ null,
        /* 349 */ null,
        /* 350 */ null,
        /* 351 */ null,
        /* 352 */ null,
        /* 353 */ null,
        /* 354 */ null,
        /* 355 */ null,
        /* 356 */ null,
        /* 357 */ null,
        /* 358 */ null,
        /* 359 */ null,
        /* 360 */ null,
        /* 361 */ null,
        /* 362 */ null,
        /* 363 */ null,
        /* 364 */ null,
        /* 365 */ null,
        /* 366 */ null,
        /* 367 */ null,
        /* 368 */ null,
        /* 369 */ null,
        /* 370 */ null,
        /* 371 */ null,
        /* 372 */ null,
        /* 373 */ null,
        /* 374 */ null,
        /* 375 */ null,
        /* 376 */ null,
        /* 377 */ null,
        /* 378 */ null,
        /* 379 */ null,
        /* 380 */ null,
        /* 381 */ null,
        /* 382 */ null,
        /* 383 */ null,
        /* 384 */ null,
        /* 385 */ null,
        /* 386 */ null,
        /* 387 */ null,
        /* 388 */ null,
        /* 389 */ null,
        /* 390 */ null,
        /* 391 */ null,
        /* 392 */ null,
        /* 393 */ null,
        /* 394 */ null,
        /* 395 */ null,
        /* 396 */ null,
        /* 397 */ null,
        /* 398 */ null,
        /* 399 */ null,
        /* 400 */ null,
        /* 401 */ null,
        /* 402 */ null,
        /* 403 */ null,
        /* 404 */ null,
        /* 405 */ null,
        /* 406 */ null,
        /* 407 */ null,
        /* 408 */ null,
        /* 409 */ null,
        /* 410 */ null,
        /* 411 */ null,
        /* 412 */ null,
        /* 413 */ null,
        /* 414 */ null,
        /* 415 */ null,
        /* 416 */ null,
        /* 417 */ null,
        /* 418 */ null,
        /* 419 */ null,
        /* 420 */ null,
        /* 421 */ null,
        /* 422 */ null,
        /* 423 */ null,
        /* 424 */ null,
        /* 425 */ null,
        /* 426 */ null,
        /* 427 */ null,
        /* 428 */ null,
        /* 429 */ null,
        /* 430 */ null,
        /* 431 */ null,
        /* 432 */ null,
        /* 433 */ null,
        /* 434 */ null,
        /* 435 */ null,
        /* 436 */ null,
        /* 437 */ null,
        /* 438 */ null,
        /* 439 */ null,
        /* 440 */ null,
        /* 441 */ null,
        /* 442 */ null,
        /* 443 */ null,
        /* 444 */ null,
        /* 445 */ null,
        /* 446 */ null,
        /* 447 */ null,
        /* 448 */ null,
        /* 449 */ null,
        /* 450 */ null,
        /* 451 */ null,
        /* 452 */ null,
        /* 453 */ null,
        /* 454 */ null,
        /* 455 */ null,
        /* 456 */ null,
        /* 457 */ null,
        /* 458 */ null,
        /* 459 */ null,
        /* 460 */ null,
        /* 461 */ null,
        /* 462 */ null,
        /* 463 */ null,
        /* 464 */ null,
        /* 465 */ typeof(CDOTAUserMsg_AIDebugLine),
        /* 466 */ typeof(CDOTAUserMsg_ChatEvent),
        /* 467 */ typeof(CDOTAUserMsg_CombatHeroPositions),
        /* 468 */ null,
        /* 469 */ null,
        /* 470 */ typeof(CDOTAUserMsg_CombatLogBulkData),
        /* 471 */ typeof(CDOTAUserMsg_CreateLinearProjectile),
        /* 472 */ typeof(CDOTAUserMsg_DestroyLinearProjectile),
        /* 473 */ typeof(CDOTAUserMsg_DodgeTrackingProjectiles),
        /* 474 */ typeof(CDOTAUserMsg_GlobalLightColor),
        /* 475 */ typeof(CDOTAUserMsg_GlobalLightDirection),
        /* 476 */ typeof(CDOTAUserMsg_InvalidCommand),
        /* 477 */ typeof(CDOTAUserMsg_LocationPing),
        /* 478 */ typeof(CDOTAUserMsg_MapLine),
        /* 479 */ typeof(CDOTAUserMsg_MiniKillCamInfo),
        /* 480 */ typeof(CDOTAUserMsg_MinimapDebugPoint),
        /* 481 */ typeof(CDOTAUserMsg_MinimapEvent),
        /* 482 */ typeof(CDOTAUserMsg_NevermoreRequiem),
        /* 483 */ typeof(CDOTAUserMsg_OverheadEvent),
        /* 484 */ typeof(CDOTAUserMsg_SetNextAutobuyItem),
        /* 485 */ typeof(CDOTAUserMsg_SharedCooldown),
        /* 486 */ typeof(CDOTAUserMsg_SpectatorPlayerClick),
        /* 487 */ typeof(CDOTAUserMsg_TutorialTipInfo),
        /* 488 */ typeof(CDOTAUserMsg_UnitEvent),
        /* 489 */ null,
        /* 490 */ typeof(CDOTAUserMsg_BotChat),
        /* 491 */ typeof(CDOTAUserMsg_HudError),
        /* 492 */ typeof(CDOTAUserMsg_ItemPurchased),
        /* 493 */ typeof(CDOTAUserMsg_Ping),
        /* 494 */ typeof(CDOTAUserMsg_ItemFound),
        /* 495 */ null,
        /* 496 */ typeof(CDOTAUserMsg_SwapVerify),
        /* 497 */ typeof(CDOTAUserMsg_WorldLine),
        /* 498 */ typeof(CMsgGCToClientTournamentItemDrop),
        /* 499 */ typeof(CDOTAUserMsg_ItemAlert),
        /* 500 */ typeof(CDOTAUserMsg_HalloweenDrops),
        /* 501 */ typeof(CDOTAUserMsg_ChatWheel),
        /* 502 */ typeof(CDOTAUserMsg_ReceivedXmasGift),
        /* 503 */ typeof(CDOTAUserMsg_UpdateSharedContent),
        /* 504 */ typeof(CDOTAUserMsg_TutorialRequestExp),
        /* 505 */ typeof(CDOTAUserMsg_TutorialPingMinimap),
        /* 506 */ typeof(CDOTAUserMsg_GamerulesStateChanged),
        /* 507 */ typeof(CDOTAUserMsg_ShowSurvey),
        /* 508 */ typeof(CDOTAUserMsg_TutorialFade),
        /* 509 */ typeof(CDOTAUserMsg_AddQuestLogEntry),
        /* 510 */ typeof(CDOTAUserMsg_SendStatPopup),
        /* 511 */ typeof(CDOTAUserMsg_TutorialFinish),
        /* 512 */ typeof(CDOTAUserMsg_SendRoshanPopup),
        /* 513 */ typeof(CDOTAUserMsg_SendGenericToolTip),
        /* 514 */ typeof(CDOTAUserMsg_SendFinalGold),
        /* 515 */ typeof(CDOTAUserMsg_CustomMsg),
        /* 516 */ typeof(CDOTAUserMsg_CoachHUDPing),
        /* 517 */ typeof(CDOTAUserMsg_ClientLoadGridNav),
        /* 518 */ typeof(CDOTAUserMsg_TE_Projectile),
        /* 519 */ typeof(CDOTAUserMsg_TE_ProjectileLoc),
        /* 520 */ typeof(CDOTAUserMsg_TE_DotaBloodImpact),
        /* 521 */ typeof(CDOTAUserMsg_TE_UnitAnimation),
        /* 522 */ typeof(CDOTAUserMsg_TE_UnitAnimationEnd),
        /* 523 */ typeof(CDOTAUserMsg_AbilityPing),
        /* 524 */ typeof(CDOTAUserMsg_ShowGenericPopup),
        /* 525 */ typeof(CDOTAUserMsg_VoteStart),
        /* 526 */ typeof(CDOTAUserMsg_VoteUpdate),
        /* 527 */ typeof(CDOTAUserMsg_VoteEnd),
        /* 528 */ typeof(CDOTAUserMsg_BoosterState),
        /* 529 */ typeof(CDOTAUserMsg_WillPurchaseAlert),
        /* 530 */ typeof(CDOTAUserMsg_TutorialMinimapPosition),
        /* 531 */ null,
        /* 532 */ typeof(CDOTAUserMsg_AbilitySteal),
        /* 533 */ typeof(CDOTAUserMsg_CourierKilledAlert),
        /* 534 */ typeof(CDOTAUserMsg_EnemyItemAlert),
        /* 535 */ typeof(CDOTAUserMsg_StatsMatchDetails),
        /* 536 */ typeof(CDOTAUserMsg_MiniTaunt),
        /* 537 */ typeof(CDOTAUserMsg_BuyBackStateAlert),
        /* 538 */ typeof(CDOTAUserMsg_SpeechBubble),
        /* 539 */ typeof(CDOTAUserMsg_CustomHeaderMessage),
        /* 540 */ typeof(CDOTAUserMsg_QuickBuyAlert),
        /* 541 */ typeof(CDOTAUserMsg_StatsHeroMinuteDetails),
        /* 542 */ null,
        /* 543 */ typeof(CDOTAUserMsg_ModifierAlert),
        /* 544 */ typeof(CDOTAUserMsg_HPManaAlert),
        /* 545 */ typeof(CDOTAUserMsg_GlyphAlert),
        /* 546 */ typeof(CDOTAUserMsg_BeastChat),
        /* 547 */ typeof(CDOTAUserMsg_SpectatorPlayerUnitOrders),
        /* 548 */ typeof(CDOTAUserMsg_CustomHudElement_Create),
        /* 549 */ typeof(CDOTAUserMsg_CustomHudElement_Modify),
        /* 550 */ typeof(CDOTAUserMsg_CustomHudElement_Destroy),
        /* 551 */ typeof(CDOTAUserMsg_CompendiumState),
        /* 552 */ typeof(CDOTAUserMsg_ProjectionAbility),
        /* 553 */ typeof(CDOTAUserMsg_ProjectionEvent),
        /* 554 */ typeof(CMsgDOTACombatLogEntry),
        /* 555 */ typeof(CDOTAUserMsg_XPAlert),
        /* 556 */ typeof(CDOTAUserMsg_UpdateQuestProgress),
        /* 557 */ typeof(CDOTAMatchMetadataFile),
        /* 558 */ null,
        /* 559 */ typeof(CDOTAUserMsg_QuestStatus),
        /* 560 */ typeof(CDOTAUserMsg_SuggestHeroPick),
        /* 561 */ typeof(CDOTAUserMsg_SuggestHeroRole),
        /* 562 */ typeof(CDOTAUserMsg_KillcamDamageTaken),
        /* 563 */ typeof(CDOTAUserMsg_SelectPenaltyGold),
        /* 564 */ typeof(CDOTAUserMsg_RollDiceResult),
        /* 565 */ typeof(CDOTAUserMsg_FlipCoinResult),
        /* 566 */ null,
        /* 567 */ null,
        /* 568 */ typeof(CDOTAUserMsg_SendRoshanSpectatorPhase),
        /* 569 */ typeof(CDOTAUserMsg_ChatWheelCooldown),
        /* 570 */ typeof(CDOTAUserMsg_DismissAllStatPopups),
        /* 571 */ typeof(CDOTAUserMsg_TE_DestroyProjectile),
        /* 572 */ typeof(CDOTAUserMsg_HeroRelicProgress),
        /* 573 */ typeof(CDOTAUserMsg_AbilityDraftRequestAbility),
        /* 574 */ typeof(CDOTAUserMsg_ItemSold),
        /* 575 */ typeof(CDOTAUserMsg_DamageReport),
        /* 576 */ typeof(CDOTAUserMsg_SalutePlayer),
        /* 577 */ typeof(CDOTAUserMsg_TipAlert),
        /* 578 */ typeof(CDOTAUserMsg_ReplaceQueryUnit),
        /* 579 */ typeof(CDOTAUserMsg_EmptyTeleportAlert),
        /* 580 */ typeof(CDOTAUserMsg_MarsArenaOfBloodAttack),
        /* 581 */ typeof(CDOTAUserMsg_ESArcanaCombo),
        /* 582 */ typeof(CDOTAUserMsg_ESArcanaComboSummary),
        /* 583 */ typeof(CDOTAUserMsg_HighFiveLeftHanging),
        /* 584 */ typeof(CDOTAUserMsg_HighFiveCompleted),
        /* 585 */ typeof(CDOTAUserMsg_ShovelUnearth),
        /* 586 */ null,
        /* 587 */ typeof(CDOTAUserMsg_RadarAlert),
        /* 588 */ typeof(CDOTAUserMsg_AllStarEvent),
        /* 589 */ typeof(CDOTAUserMsg_TalentTreeAlert),
        /* 590 */ typeof(CDOTAUserMsg_QueuedOrderRemoved),
        /* 591 */ typeof(CDOTAUserMsg_DebugChallenge),
        /* 592 */ typeof(CDOTAUserMsg_OMArcanaCombo),
        /* 593 */ typeof(CDOTAUserMsg_FoundNeutralItem),
        /* 594 */ typeof(CDOTAUserMsg_OutpostCaptured),
        /* 595 */ typeof(CDOTAUserMsg_OutpostGrantedXP),
        /* 596 */ typeof(CDOTAUserMsg_MoveCameraToUnit),
        /* 597 */ typeof(CDOTAUserMsg_PauseMinigameData),
        /* 598 */ typeof(CDOTAUserMsg_VersusScene_PlayerBehavior),
        /* 599 */ null,
        /* 600 */ typeof(CDOTAUserMsg_QoP_ArcanaSummary),
        /* 601 */ typeof(CDOTAUserMsg_HotPotato_Created),
        /* 602 */ typeof(CDOTAUserMsg_HotPotato_Exploded),
        /* 603 */ typeof(CDOTAUserMsg_WK_Arcana_Progress),
        /* 604 */ typeof(CDOTAUserMsg_GuildChallenge_Progress),
        /* 605 */ typeof(CDOTAUserMsg_WRArcanaProgress),
        /* 606 */ typeof(CDOTAUserMsg_WRArcanaSummary),
        /* 607 */ typeof(CDOTAUserMsg_EmptyItemSlotAlert),
        /* 608 */ typeof(CDOTAUserMsg_AghsStatusAlert),
        /* 609 */ typeof(CDOTAUserMsg_PingConfirmation),
        /* 610 */ typeof(CDOTAUserMsg_MutedPlayers),
        /* 611 */ typeof(CDOTAUserMsg_ContextualTip),
        /* 612 */ typeof(CDOTAUserMsg_ChatMessage),
        /* 613 */ typeof(CDOTAUserMsg_NeutralCampAlert),
        /* 614 */ typeof(CDOTAUserMsg_RockPaperScissorsStarted),
        /* 615 */ typeof(CDOTAUserMsg_RockPaperScissorsFinished),
        /* 616 */ typeof(CDOTAUserMsg_DuelOpponentKilled),
        /* 617 */ typeof(CDOTAUserMsg_DuelAccepted),
        /* 618 */ typeof(CDOTAUserMsg_DuelRequested),
        /* 619 */ typeof(CDOTAUserMsg_MuertaReleaseEvent_AssignedTargetKilled),
        /* 620 */ typeof(CDOTAUserMsg_PlayerDraftSuggestPick),
        /* 621 */ typeof(CDOTAUserMsg_PlayerDraftPick),
        /* 622 */ typeof(CDOTAUserMsg_UpdateLinearProjectileCPData),
        /* 623 */ typeof(CDOTAUserMsg_GiftPlayer),
        /* 624 */ typeof(CDOTAUserMsg_FacetPing),
        /* 625 */ typeof(CDOTAUserMsg_InnatePing),
        /* 626 */ typeof(CDOTAUserMsg_RoshanTimer),
        /* 627 */ typeof(CDOTAUserMsg_NeutralCraftAvailable),
        /* 628 */ typeof(CDOTAUserMsg_TimerAlert),
        /* 629 */ typeof(CDOTAUserMsg_MadstoneAlert),

    ];
#pragma warning restore CS8625
};