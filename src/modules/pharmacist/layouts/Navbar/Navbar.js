import React, { useState } from 'react'

import { useSelector, useDispatch } from 'react-redux'
import { changeTheme } from '../../../../store/slices/themeReducer'

import SystemInfo from '../../../../components/SystemInfo/SystemInfo'

import { useNavigate } from 'react-router-dom'
import styles from './Navbar.module.css'
import { FaInfoCircle } from 'react-icons/fa'
import { FaSignOutAlt } from 'react-icons/fa'
import { FaSun } from 'react-icons/fa'
import { FaMoon } from 'react-icons/fa'

export default function Navbar() {
	const navigate = useNavigate()

	const dispatch = useDispatch()

	const { theme } = useSelector(state => state.theme)

	const [info, setInfo] = useState(false)

	const handleToggleInfo = () => {
		setInfo(!info)
	}

	const handleSignout = () => {
		navigate('/signin/pharmacist')
	}

	const handleChangeTheme = () => {
		dispatch(changeTheme())
	}

  return (
		<>
			<nav className={`${styles.navbar} ${theme === 'dark' && styles.dark}`}>
				<h1>PHADEC-1</h1>
				<ul>
					<li onClick={handleToggleInfo}>
						<span className={styles.text}>system information</span>{' '}
						<FaInfoCircle />
					</li>
					<li
						onClick={handleChangeTheme}
						className={`${styles.toggle} ${theme === 'dark' && styles.dark}`}
					>
						<FaMoon className={styles.moon} />
						<FaSun className={styles.sun} />
						<span
							className={`${styles.circle} ${theme === 'dark' && styles.dark}`}
						></span>
					</li>
					<li onClick={handleSignout}>
						<span className={styles.text}>sign out</span> <FaSignOutAlt />
					</li>
				</ul>
			</nav>
			{info && <SystemInfo handleClose={setInfo} />}
		</>
	)
}
